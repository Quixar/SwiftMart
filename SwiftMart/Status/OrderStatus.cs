using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents the various statuses of an order in the SwiftMart system.
/// </summary>
namespace SwiftMart.Status
{
    public enum OrderStatus
    {

        /// <summary>
        /// The order has been placed but is awaiting confirmation.
        /// </summary>
        Pending,

        /// <summary>
        /// The order has been confirmed and is ready for processing.
        /// </summary>
        Confirmed,

        /// <summary>
        /// The order has been shipped and is on its way to the customer.
        /// </summary>
        Shipped,

        /// <summary>
        /// The order has been successfully delivered to the customer.
        /// </summary>
        Delivered,

        /// <summary>
        /// The order has been canceled and will not be processed.
        /// </summary>
        Canceled
    }
}
