//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Guild.Tax
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class TaxCollectorStateUpdateMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6455;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_uniqueId;
        
        public virtual int UniqueId
        {
            get
            {
                return m_uniqueId;
            }
            set
            {
                m_uniqueId = value;
            }
        }
        
        private byte m_state;
        
        public virtual byte State
        {
            get
            {
                return m_state;
            }
            set
            {
                m_state = value;
            }
        }
        
        public TaxCollectorStateUpdateMessage(int uniqueId, byte state)
        {
            m_uniqueId = uniqueId;
            m_state = state;
        }
        
        public TaxCollectorStateUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_uniqueId);
            writer.WriteByte(m_state);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_uniqueId = reader.ReadInt();
            m_state = reader.ReadByte();
        }
    }
}
