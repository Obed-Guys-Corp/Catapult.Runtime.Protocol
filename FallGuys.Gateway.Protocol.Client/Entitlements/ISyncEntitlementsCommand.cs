namespace FallGuys.Gateway.Protocol.Client.Entitlements;

public interface ISyncEntitlementsCommand
{
    string CurrencyCode { set; }

    string StoreId { set; }

    string StorefrontId { set; }

    string SectionId { set; }

    string IapId { set; }

    string StoreSessionId { set; }
}
