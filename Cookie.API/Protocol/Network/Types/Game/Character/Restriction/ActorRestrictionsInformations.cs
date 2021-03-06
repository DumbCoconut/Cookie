//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Character.Restriction
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ActorRestrictionsInformations : NetworkType
    {
        
        public const short ProtocolId = 204;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_cantBeAggressed;
        
        public virtual bool CantBeAggressed
        {
            get
            {
                return m_cantBeAggressed;
            }
            set
            {
                m_cantBeAggressed = value;
            }
        }
        
        private bool m_cantBeChallenged;
        
        public virtual bool CantBeChallenged
        {
            get
            {
                return m_cantBeChallenged;
            }
            set
            {
                m_cantBeChallenged = value;
            }
        }
        
        private bool m_cantTrade;
        
        public virtual bool CantTrade
        {
            get
            {
                return m_cantTrade;
            }
            set
            {
                m_cantTrade = value;
            }
        }
        
        private bool m_cantBeAttackedByMutant;
        
        public virtual bool CantBeAttackedByMutant
        {
            get
            {
                return m_cantBeAttackedByMutant;
            }
            set
            {
                m_cantBeAttackedByMutant = value;
            }
        }
        
        private bool m_cantRun;
        
        public virtual bool CantRun
        {
            get
            {
                return m_cantRun;
            }
            set
            {
                m_cantRun = value;
            }
        }
        
        private bool m_forceSlowWalk;
        
        public virtual bool ForceSlowWalk
        {
            get
            {
                return m_forceSlowWalk;
            }
            set
            {
                m_forceSlowWalk = value;
            }
        }
        
        private bool m_cantMinimize;
        
        public virtual bool CantMinimize
        {
            get
            {
                return m_cantMinimize;
            }
            set
            {
                m_cantMinimize = value;
            }
        }
        
        private bool m_cantMove;
        
        public virtual bool CantMove
        {
            get
            {
                return m_cantMove;
            }
            set
            {
                m_cantMove = value;
            }
        }
        
        private bool m_cantAggress;
        
        public virtual bool CantAggress
        {
            get
            {
                return m_cantAggress;
            }
            set
            {
                m_cantAggress = value;
            }
        }
        
        private bool m_cantChallenge;
        
        public virtual bool CantChallenge
        {
            get
            {
                return m_cantChallenge;
            }
            set
            {
                m_cantChallenge = value;
            }
        }
        
        private bool m_cantExchange;
        
        public virtual bool CantExchange
        {
            get
            {
                return m_cantExchange;
            }
            set
            {
                m_cantExchange = value;
            }
        }
        
        private bool m_cantAttack;
        
        public virtual bool CantAttack
        {
            get
            {
                return m_cantAttack;
            }
            set
            {
                m_cantAttack = value;
            }
        }
        
        private bool m_cantChat;
        
        public virtual bool CantChat
        {
            get
            {
                return m_cantChat;
            }
            set
            {
                m_cantChat = value;
            }
        }
        
        private bool m_cantBeMerchant;
        
        public virtual bool CantBeMerchant
        {
            get
            {
                return m_cantBeMerchant;
            }
            set
            {
                m_cantBeMerchant = value;
            }
        }
        
        private bool m_cantUseObject;
        
        public virtual bool CantUseObject
        {
            get
            {
                return m_cantUseObject;
            }
            set
            {
                m_cantUseObject = value;
            }
        }
        
        private bool m_cantUseTaxCollector;
        
        public virtual bool CantUseTaxCollector
        {
            get
            {
                return m_cantUseTaxCollector;
            }
            set
            {
                m_cantUseTaxCollector = value;
            }
        }
        
        private bool m_cantUseInteractive;
        
        public virtual bool CantUseInteractive
        {
            get
            {
                return m_cantUseInteractive;
            }
            set
            {
                m_cantUseInteractive = value;
            }
        }
        
        private bool m_cantSpeakToNPC;
        
        public virtual bool CantSpeakToNPC
        {
            get
            {
                return m_cantSpeakToNPC;
            }
            set
            {
                m_cantSpeakToNPC = value;
            }
        }
        
        private bool m_cantChangeZone;
        
        public virtual bool CantChangeZone
        {
            get
            {
                return m_cantChangeZone;
            }
            set
            {
                m_cantChangeZone = value;
            }
        }
        
        private bool m_cantAttackMonster;
        
        public virtual bool CantAttackMonster
        {
            get
            {
                return m_cantAttackMonster;
            }
            set
            {
                m_cantAttackMonster = value;
            }
        }
        
        private bool m_cantWalk8Directions;
        
        public virtual bool CantWalk8Directions
        {
            get
            {
                return m_cantWalk8Directions;
            }
            set
            {
                m_cantWalk8Directions = value;
            }
        }
        
        public ActorRestrictionsInformations(
                    bool cantBeAggressed, 
                    bool cantBeChallenged, 
                    bool cantTrade, 
                    bool cantBeAttackedByMutant, 
                    bool cantRun, 
                    bool forceSlowWalk, 
                    bool cantMinimize, 
                    bool cantMove, 
                    bool cantAggress, 
                    bool cantChallenge, 
                    bool cantExchange, 
                    bool cantAttack, 
                    bool cantChat, 
                    bool cantBeMerchant, 
                    bool cantUseObject, 
                    bool cantUseTaxCollector, 
                    bool cantUseInteractive, 
                    bool cantSpeakToNPC, 
                    bool cantChangeZone, 
                    bool cantAttackMonster, 
                    bool cantWalk8Directions)
        {
            m_cantBeAggressed = cantBeAggressed;
            m_cantBeChallenged = cantBeChallenged;
            m_cantTrade = cantTrade;
            m_cantBeAttackedByMutant = cantBeAttackedByMutant;
            m_cantRun = cantRun;
            m_forceSlowWalk = forceSlowWalk;
            m_cantMinimize = cantMinimize;
            m_cantMove = cantMove;
            m_cantAggress = cantAggress;
            m_cantChallenge = cantChallenge;
            m_cantExchange = cantExchange;
            m_cantAttack = cantAttack;
            m_cantChat = cantChat;
            m_cantBeMerchant = cantBeMerchant;
            m_cantUseObject = cantUseObject;
            m_cantUseTaxCollector = cantUseTaxCollector;
            m_cantUseInteractive = cantUseInteractive;
            m_cantSpeakToNPC = cantSpeakToNPC;
            m_cantChangeZone = cantChangeZone;
            m_cantAttackMonster = cantAttackMonster;
            m_cantWalk8Directions = cantWalk8Directions;
        }
        
        public ActorRestrictionsInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            byte flag = new byte();
            BooleanByteWrapper.SetFlag(0, flag, m_cantBeAggressed);
            BooleanByteWrapper.SetFlag(1, flag, m_cantBeChallenged);
            BooleanByteWrapper.SetFlag(2, flag, m_cantTrade);
            BooleanByteWrapper.SetFlag(3, flag, m_cantBeAttackedByMutant);
            BooleanByteWrapper.SetFlag(4, flag, m_cantRun);
            BooleanByteWrapper.SetFlag(5, flag, m_forceSlowWalk);
            BooleanByteWrapper.SetFlag(6, flag, m_cantMinimize);
            BooleanByteWrapper.SetFlag(7, flag, m_cantMove);
            BooleanByteWrapper.SetFlag(0, flag, m_cantAggress);
            BooleanByteWrapper.SetFlag(1, flag, m_cantChallenge);
            BooleanByteWrapper.SetFlag(2, flag, m_cantExchange);
            BooleanByteWrapper.SetFlag(3, flag, m_cantAttack);
            BooleanByteWrapper.SetFlag(4, flag, m_cantChat);
            BooleanByteWrapper.SetFlag(5, flag, m_cantBeMerchant);
            BooleanByteWrapper.SetFlag(6, flag, m_cantUseObject);
            BooleanByteWrapper.SetFlag(7, flag, m_cantUseTaxCollector);
            BooleanByteWrapper.SetFlag(0, flag, m_cantUseInteractive);
            BooleanByteWrapper.SetFlag(1, flag, m_cantSpeakToNPC);
            BooleanByteWrapper.SetFlag(2, flag, m_cantChangeZone);
            BooleanByteWrapper.SetFlag(3, flag, m_cantAttackMonster);
            BooleanByteWrapper.SetFlag(4, flag, m_cantWalk8Directions);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            byte flag = reader.ReadByte();
            m_cantBeAggressed = BooleanByteWrapper.GetFlag(flag, 0);
            m_cantBeChallenged = BooleanByteWrapper.GetFlag(flag, 1);
            m_cantTrade = BooleanByteWrapper.GetFlag(flag, 2);
            m_cantBeAttackedByMutant = BooleanByteWrapper.GetFlag(flag, 3);
            m_cantRun = BooleanByteWrapper.GetFlag(flag, 4);
            m_forceSlowWalk = BooleanByteWrapper.GetFlag(flag, 5);
            m_cantMinimize = BooleanByteWrapper.GetFlag(flag, 6);
            m_cantMove = BooleanByteWrapper.GetFlag(flag, 7);
            flag = reader.ReadByte();
            m_cantAggress = BooleanByteWrapper.GetFlag(flag, 0);
            m_cantChallenge = BooleanByteWrapper.GetFlag(flag, 1);
            m_cantExchange = BooleanByteWrapper.GetFlag(flag, 2);
            m_cantAttack = BooleanByteWrapper.GetFlag(flag, 3);
            m_cantChat = BooleanByteWrapper.GetFlag(flag, 4);
            m_cantBeMerchant = BooleanByteWrapper.GetFlag(flag, 5);
            m_cantUseObject = BooleanByteWrapper.GetFlag(flag, 6);
            m_cantUseTaxCollector = BooleanByteWrapper.GetFlag(flag, 7);
            flag = reader.ReadByte();
            m_cantUseInteractive = BooleanByteWrapper.GetFlag(flag, 0);
            m_cantSpeakToNPC = BooleanByteWrapper.GetFlag(flag, 1);
            m_cantChangeZone = BooleanByteWrapper.GetFlag(flag, 2);
            m_cantAttackMonster = BooleanByteWrapper.GetFlag(flag, 3);
            m_cantWalk8Directions = BooleanByteWrapper.GetFlag(flag, 4);
        }
    }
}
