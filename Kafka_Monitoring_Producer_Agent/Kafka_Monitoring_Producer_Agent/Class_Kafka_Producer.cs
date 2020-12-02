using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Confluent.Kafka;

namespace Kafka_Monitoring_Producer_Agent
{
    public class Class_Kafka_Producer
    {
        public async Task Send_Async(string Address, string Topic, string Data, int Timeout)
        {
            ProducerResponse.Message = "";
            ProducerResponse.IsWaitingResponse = true;

            var config = new ProducerConfig
            {
                BootstrapServers = Address,
                MessageTimeoutMs = Timeout,
                #region gak dipake
                //ApiVersionRequestTimeoutMs = 2000,
                //MetadataRequestTimeoutMs = 6000,
                //RequestTimeoutMs = 8000,
                //SocketTimeoutMs = 10000,
                //TransactionTimeoutMs = 12000
                #endregion
            };

            using (var p = new ProducerBuilder<Null, string>(config).Build())
            {
                try
                {
                    var dr = await p.ProduceAsync(Topic, new Message<Null, string> { Value = Data });
                    ProducerResponse.Message = "OK";
                    ProducerResponse.SendResponse = true;
                    ProducerResponse.Offset = dr.TopicPartitionOffset.Offset.Value;
                }
                catch (ProduceException<Null, string> e)
                {
                    ProducerResponse.Message = e.Error.Reason;
                    ProducerResponse.SendResponse = true;
                }
            }
            ProducerResponse.IsWaitingResponse = false;
        }
    }

    public static class ProducerResponse
    {
        public static bool IsWaitingResponse { get; set; }
        public static bool SendResponse { get; set; }
        public static long Offset { get; set; }
        public static string Message { get; set; }

    }
}
