package kafka_monitoring_consumer_agent;

import org.apache.kafka.clients.consumer.ConsumerConfig;
import org.apache.kafka.clients.consumer.ConsumerRecord;
import org.apache.kafka.clients.consumer.ConsumerRecords;
import org.apache.kafka.clients.consumer.KafkaConsumer;
import org.apache.kafka.common.KafkaException;
import org.apache.kafka.common.serialization.StringDeserializer;

import java.sql.*;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.time.Duration;
import java.util.Arrays;
import java.util.Date;
import java.util.Properties;
import java.util.Scanner;

public class Kafka_Monitoring_Consumer_Agent {

    static String ServerAddress;
    static String TopicName;
    static Long ConsumerTimeout;

    static String DB_driver = "org.postgresql.Driver";
    static String DB_url = "jdbc:postgresql://192.168.1.14:5432/Kafka_Monitoring";
    static String DB_user = "postgres";
    static String DB_password = "postgres";
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println("Apps Kafka Monitoring Consumer v0.0.0.1");
        
        System.out.print("Kafka Server Address (ex: 192.168.204.2:9092) : "); 
        ServerAddress = in.nextLine();
        
        System.out.print("Database Address (ex: 192.168.1.14:5432) : "); 
        DB_url = "jdbc:postgresql://" + in.nextLine() + "/Kafka_Monitoring";
        
        System.out.print("Topic Name : "); 
        TopicName = in.nextLine();
        
        System.out.print("Timeout : "); 
        ConsumerTimeout = in.nextLong();


        Properties props = new Properties();
        props.put(ConsumerConfig.BOOTSTRAP_SERVERS_CONFIG, ServerAddress);
        props.put(ConsumerConfig.GROUP_ID_CONFIG, "test");
        props.put(ConsumerConfig.ENABLE_AUTO_COMMIT_CONFIG, "true");
        props.put(ConsumerConfig.AUTO_COMMIT_INTERVAL_MS_CONFIG, "1000");
        props.put(ConsumerConfig.KEY_DESERIALIZER_CLASS_CONFIG, StringDeserializer.class.getName());
        props.put(ConsumerConfig.VALUE_DESERIALIZER_CLASS_CONFIG, StringDeserializer.class.getName());

        KafkaConsumer<String, String> consumer = new KafkaConsumer<>(props);
        consumer.subscribe(Arrays.asList(TopicName));

        while (true)
        {
            try
            {
                ConsumerRecords<String, String> records = consumer.poll(Duration.ofMillis(ConsumerTimeout));
                for (ConsumerRecord<String, String> record :records)
                {
                    System.out.println(String.format("Time : %s, Topic : %s, Partition : %d, Offset : %d, Data : %s",
                            MillisToDateString(record.timestamp()),
                            record.topic(),
                            record.partition(),
                            record.offset(),
                            record.value()
                    ));
                    SendDataMonitoring(MillisToDateString(record.timestamp()),
                            record.topic(),
                            record.partition(),
                            record.offset(),
                            record.value());
                }
            }
            catch (KafkaException e)
            {
                System.out.println("data exception : " + e.getCause().getMessage());
            }
        }
    }

    static boolean SendDataMonitoring(String Time, String Topic, int Partition, long Offset, String Data)
    {
        Connection c = null;
        Statement stmt = null;
        try
        {
            //set Query
            String query = String.format("INSERT INTO dms.t_mtr_device_monitoring(%s)VALUES('%s',%d,%d,'%s','%s');",
                    "topic_name_var, topic_partition_int, topic_offset_int, data_received_on_dtm, data_var",
                    Topic,
                    Partition,
                    Offset,
                    Time,
                    Data);
            System.out.println("Query: " + query);
            // open database
            Class.forName(DB_driver);
            c = DriverManager.getConnection(DB_url, DB_user, DB_password);
            c.setAutoCommit(false);

            //insert data to database
            stmt = c.createStatement();
            stmt.executeUpdate(query);

            //close connection
            stmt.close();
            c.commit();
            c.close();
            return true;
        }
        catch (Exception e)
        {
            System.out.println("Failed Query: " + e.getMessage());
        }
        return false;
    }

    static String MillisToDateString(long millis)
    {
        //convert long millis to date
        Date dt = new Date(millis);

        //convert date to string with format
        DateFormat df = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
        return df.format(dt);
    }
}
