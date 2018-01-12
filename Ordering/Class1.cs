using BusterWood.Goodies;
using System;

namespace OpenOms.Ordering
{
    /// <summary>A decision is made to trade</summary>
    public class InvestmentDecision
    {
        public Guid<InvestmentDecision> InvestmentDecisionId { get; set; }
        public Int32<User> DecisionMakerId { get; set; }
        public Int32<User> InputterId { get; set; }
        public DateTimeOffset DecisionTaken { get; set; }
        public string Description { get; set; }

        /// <summary>Does this investment roll to the next trade date if not fully traded on the first day?</summary>
        public bool Roll { get; set; }
        
        /// <summary>Source of this investment, if it came from outside</summary>
        public string SourceSystem { get; set; }

        /// <summary>Any external ID associated with this <see cref="InvestmentDecision"/></summary>
        public string ExternalId { get; set; }
    }

    /// <summary>A user of the system</summary>
    public class User
    {
        public Int32<User> UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    /// <summary>A <see cref="InvestmentDecision"/> to trade a specific <see cref="SecurityId"/></summary>
    public class Order
    {
        public Guid<Order> OrderId { get; set; }

        public Guid<InvestmentDecision> InvestmentDecisionId { get; set; }

        public Int32<Security> SecurityId { get; set; }

        /// <summary>If set then this is a limit order, other wise a market order</summary>
        public decimal? LimitPrice { get; set; }

        public string Comments { get; set; }

        /// <summary>ISO currency code</summary>
        public string CurrencyCode { get; set; }

        /// <summary>Any external ID associated with this <see cref="Order"/></summary>
        public string ExternalId { get; set; }
    }

    public class ExecutionDirections
    {
        public Int32<Ems> EmsId { get; set; }
        
        /// <summary>How to execute</summary>
        public int ExecutionStyle { get; set; }
    }

    public class Ems
    {
        public Int32<Ems> EmsId { get; set; }
        public string Name { get; set; }
    }

    /// <summary>Part of a an <see cref="Order"/> with a <see cref="Quantity"/> for a <see cref="Beneficiary"/></summary>
    public class OrderLine
    {
        public Guid<Order> OrderId { get; set; }
        public decimal Quantity { get; set; }
        public Guid<Beneficiary> BeneficiaryId { get; set; }

        //TODO: do we need this information here? seems likely this is only for booking?

        /// <summary>Destination position that this trade effects</summary>
        public Int32<Position> PositionId { get; set; }

        /// <summary>ISO currency code of the intended position</summary>
        public string PositionCurrencyCode { get; set; }

        /// <summary>Any external ID associated with this <see cref="OrderLine"/></summary>
        public string ExternalId { get; set; }

    }

    public class Position
    {
        public Int32<Position> PositionId { get; set; }
    }

    public class Security
    {
        public string Name { get; set; }

    }

    /// <summary>The fund, or some sub-part of a fund, than an <see cref="OrderLine"/> is for, e.g. book within a fund</summary>
    public class Beneficiary
    {
        public Guid<Beneficiary> Id { get; set; }
    }

}
