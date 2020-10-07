using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Flutterwave.Net
{
    public class UpdateSubAccount
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("account_bank")]
        public string BankCode { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("meta")]
        public List<UpdateSubAccountMeta> Meta { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("split_ratio")]
        public int SplitRatio { get; set; }

        [JsonProperty("split_type")]
        public string SplitType { get; set; }

        [JsonProperty("split_value")]
        public decimal SplitValue { get; set; }

        [JsonProperty("subaccount_id")]
        public string SubaccountId { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class UpdateSubAccountMeta
    {
        [JsonProperty("meta_name")]
        public string MetaName { get; set; }

        [JsonProperty("meta_value")]
        public string MetaValue { get; set; }
    }
}