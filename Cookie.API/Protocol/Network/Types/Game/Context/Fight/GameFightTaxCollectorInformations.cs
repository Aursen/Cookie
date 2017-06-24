//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Fight
{
    using Cookie.API.IO;


    public class GameFightTaxCollectorInformations : GameFightAIInformations
    {
        
        public new const short ProtocolId = 48;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_firstNameId;
        
        public virtual ushort FirstNameId
        {
            get
            {
                return m_firstNameId;
            }
            set
            {
                m_firstNameId = value;
            }
        }
        
        private ushort m_lastNameId;
        
        public virtual ushort LastNameId
        {
            get
            {
                return m_lastNameId;
            }
            set
            {
                m_lastNameId = value;
            }
        }
        
        private sbyte m_level;
        
        public virtual sbyte Level
        {
            get
            {
                return m_level;
            }
            set
            {
                m_level = value;
            }
        }
        
        public GameFightTaxCollectorInformations(ushort firstNameId, ushort lastNameId, sbyte level)
        {
            m_firstNameId = firstNameId;
            m_lastNameId = lastNameId;
            m_level = level;
        }
        
        public GameFightTaxCollectorInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhShort(m_firstNameId);
            writer.WriteVarUhShort(m_lastNameId);
            writer.WriteSByte(m_level);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_firstNameId = reader.ReadVarUhShort();
            m_lastNameId = reader.ReadVarUhShort();
            m_level = reader.ReadSByte();
        }
    }
}