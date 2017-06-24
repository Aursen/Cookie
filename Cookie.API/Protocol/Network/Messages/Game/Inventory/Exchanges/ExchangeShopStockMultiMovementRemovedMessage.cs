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
    using Cookie.API.IO;
    
    
    public class ExchangeShopStockMultiMovementRemovedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6037;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt32> m_objectIdList;
        
        public virtual List<System.UInt32> ObjectIdList
        {
            get
            {
                return m_objectIdList;
            }
            set
            {
                m_objectIdList = value;
            }
        }
        
        public ExchangeShopStockMultiMovementRemovedMessage(List<System.UInt32> objectIdList)
        {
            m_objectIdList = objectIdList;
        }
        
        public ExchangeShopStockMultiMovementRemovedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_objectIdList.Count)));
            int objectIdListIndex;
            for (objectIdListIndex = 0; (objectIdListIndex < m_objectIdList.Count); objectIdListIndex = (objectIdListIndex + 1))
            {
                writer.WriteVarUhInt(m_objectIdList[objectIdListIndex]);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int objectIdListCount = reader.ReadUShort();
            int objectIdListIndex;
            m_objectIdList = new System.Collections.Generic.List<uint>();
            for (objectIdListIndex = 0; (objectIdListIndex < objectIdListCount); objectIdListIndex = (objectIdListIndex + 1))
            {
                m_objectIdList.Add(reader.ReadVarUhInt());
            }
        }
    }
}