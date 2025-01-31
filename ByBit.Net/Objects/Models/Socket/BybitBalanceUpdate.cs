﻿using Newtonsoft.Json;

namespace Bybit.Net.Objects.Models.Socket
{
    /// <summary>
    /// Balance update
    /// </summary>
    public class BybitBalanceUpdate
    {
        /// <summary>
        /// Wallet balance
        /// </summary>
        [JsonProperty("wallet_balance")]
        public decimal WalletBalance { get; set; }
        /// <summary>
        /// Available balance = wallet balance - used margin
        /// </summary>
        [JsonProperty("available_balance")]
        public decimal AvailbleBalance { get; set; }
    }
}
