﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8689
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, string>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty> this_PackValueOfDictStaticKeyAndStaticItemDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, System.Collections.Generic.IDictionary<string, string>> this_SetUnpackedValueOfDictStaticKeyAndStaticItemDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int> this_UnpackValueOfDictStaticKeyAndStaticItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<string, string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>(this.PackValueOfDictStaticKeyAndStaticItem);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>>(1);
            packOperationTable["DictStaticKeyAndStaticItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>(this.PackValueOfDictStaticKeyAndStaticItem);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictStaticKeyAndStaticItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int>>(1);
            unpackOperationTable["DictStaticKeyAndStaticItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictStaticKeyAndStaticItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictStaticKeyAndStaticItem"};
            this.this_PackValueOfDictStaticKeyAndStaticItemDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>(this.PackValueOfDictStaticKeyAndStaticItem);
            this.this_SetUnpackedValueOfDictStaticKeyAndStaticItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, System.Collections.Generic.IDictionary<string, string>>(this.SetUnpackedValueOfDictStaticKeyAndStaticItem);
            this.this_UnpackValueOfDictStaticKeyAndStaticItemDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictStaticKeyAndStaticItem);
        }
        
        private void PackValueOfDictStaticKeyAndStaticItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictStaticKeyAndStaticItem);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfDictStaticKeyAndStaticItem(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty unpackingContext, System.Collections.Generic.IDictionary<string, string> unpackedValue) {
            System.Collections.Generic.IDictionary<string, string> existent = default(System.Collections.Generic.IDictionary<string, string>);
            existent = unpackingContext.DictStaticKeyAndStaticItem;
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<string, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfDictStaticKeyAndStaticItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<string, string>), "DictStaticKeyAndStaticItem", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictStaticKeyAndStaticItemDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndStaticItemGetOnlyCollectionProperty>(), this._unpackOperationTable);
            }
        }
    }
}
