﻿using System.Collections.Generic;

//namespace Blockfrost.Api.Models.Cardano.Accounts
namespace Blockfrost.Api
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class StakeAddressMirsResponse
    {
        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        /// <summary>MIR amount in Lovelaces</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Amount { get; set; }

        /// <summary>Hash of the transaction containing the MIR</summary>
        [Newtonsoft.Json.JsonProperty("tx_hash", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Tx_hash { get; set; }
    }
}