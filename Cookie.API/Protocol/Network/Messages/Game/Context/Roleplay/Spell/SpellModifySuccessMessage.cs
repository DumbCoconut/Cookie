//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Spell
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class SpellModifySuccessMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6654;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_spellId;
        
        public virtual int SpellId
        {
            get
            {
                return m_spellId;
            }
            set
            {
                m_spellId = value;
            }
        }
        
        private short m_spellLevel;
        
        public virtual short SpellLevel
        {
            get
            {
                return m_spellLevel;
            }
            set
            {
                m_spellLevel = value;
            }
        }
        
        public SpellModifySuccessMessage(int spellId, short spellLevel)
        {
            m_spellId = spellId;
            m_spellLevel = spellLevel;
        }
        
        public SpellModifySuccessMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_spellId);
            writer.WriteShort(m_spellLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_spellId = reader.ReadInt();
            m_spellLevel = reader.ReadShort();
        }
    }
}
