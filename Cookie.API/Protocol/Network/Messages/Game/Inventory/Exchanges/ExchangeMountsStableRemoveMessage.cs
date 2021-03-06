//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ExchangeMountsStableRemoveMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6556;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Int32> m_mountsId;
        
        public virtual List<System.Int32> MountsId
        {
            get
            {
                return m_mountsId;
            }
            set
            {
                m_mountsId = value;
            }
        }
        
        public ExchangeMountsStableRemoveMessage(List<System.Int32> mountsId)
        {
            m_mountsId = mountsId;
        }
        
        public ExchangeMountsStableRemoveMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_mountsId.Count)));
            int mountsIdIndex;
            for (mountsIdIndex = 0; (mountsIdIndex < m_mountsId.Count); mountsIdIndex = (mountsIdIndex + 1))
            {
                writer.WriteVarInt(m_mountsId[mountsIdIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int mountsIdCount = reader.ReadUShort();
            int mountsIdIndex;
            m_mountsId = new System.Collections.Generic.List<int>();
            for (mountsIdIndex = 0; (mountsIdIndex < mountsIdCount); mountsIdIndex = (mountsIdIndex + 1))
            {
                m_mountsId.Add(reader.ReadVarInt());
            }
        }
    }
}
