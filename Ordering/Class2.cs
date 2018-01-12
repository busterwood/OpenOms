using System;
using System.Collections.Generic;
using System.Text;
using BusterWood.Collections;
using BusterWood.Goodies;

namespace OpenOms.Ordering
{
    public class ComplianceChecker
    {
        //TODO: I don't like it, this is not a function
        public ComplianceResult Check(InvestmentDecision investmentDecision)
        {
            throw new NotImplementedException();
        }
    }

    public class ComplianceResult
    {

    }

    public class ExecutionOrderCreator
    {
        public UniqueList<ExecutionOrder> CreateExecutionOrders(IEnumerable<Order> orders)
        {
            throw new NotImplementedException(); // merge order lines across orders where restrictions are compatible
        }
    }

    /// <summary>An order to be execution in the EMS</summary>
    public class ExecutionOrder
    {
        public Int32<Security> SecurityId { get; set; }

        public decimal Quantity { get; set; }

        /// <summary>Is crossing EMS?</summary>
        public bool CrossingAllowed { get; set; }

        /// <summary>Can this be mixed in the EMS?</summary>
        public bool MixingAllowed { get; set; }

        /// <summary>Can this be merged in the EMS?</summary>
        public bool MergingAllowed { get; set; }

        /// <summary>The counterparties that must be traded with, empty list mean any counterparty is okay</summary>
        public UniqueList<Int32<Counterparty>> CounterPartyWhiteList { get; set; }

        /// <summary>The counterparties that cannot be traded with, empty list mean any counterparty is okay</summary>
        public UniqueList<Int32<Counterparty>> CounterPartyBlackList { get; set; }
    }

    public class Counterparty
    {

    }
}
