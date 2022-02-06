﻿namespace Bybit.Net.Enums
{
    /// <summary>
    /// Stop order status
    /// </summary>
    public enum StopOrderStatus
    {
        /// <summary>
        /// ???
        /// </summary>
        Filled,
        /// <summary>
        /// ??? not final state
        /// Order has been triggered and the new active order has been successfully placed. Is the final state of a successful conditional order
        /// </summary>
        Active,
        /// <summary>
        /// Order yet to be triggered
        /// </summary>
        Untriggered,
        /// <summary>
        /// Order has been triggered by last traded price
        /// </summary>
        Triggered,
        /// <summary>
        /// Order has been canceled successfully
        /// </summary>
        Canceled,
        /// <summary>
        /// Order has been triggered but failed to be placed (e.g. due to insufficient margin)
        /// </summary>
        Rejected,
        /// <summary>
        /// Order has been canceled by the user before being triggered
        /// </summary>
        Deactivated
    }
}
