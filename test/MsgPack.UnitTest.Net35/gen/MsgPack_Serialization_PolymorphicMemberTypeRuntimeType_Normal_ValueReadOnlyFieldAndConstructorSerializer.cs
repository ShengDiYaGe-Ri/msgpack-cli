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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor> this_PackValueOfValueDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>> _packOperationTable;
        
        private System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor> this_CreateInstanceFromContextDelegate;
        
        private System.Action<UnpackingContext, System.DateTime> this_SetUnpackedValueOfValueDelegate;
        
        private System.Action<MsgPack.Unpacker, UnpackingContext, int, int> this_UnpackValueOfValueDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            this._serializer0 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>(this.PackValueOfValue);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>>(1);
            packOperationTable["Value"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>(this.PackValueOfValue);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfValue);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>(1);
            unpackOperationTable["Value"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfValue);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Value"};
            this.this_PackValueOfValueDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>(this.PackValueOfValue);
            this.this_CreateInstanceFromContextDelegate = new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor>(this.CreateInstanceFromContext);
            this.this_SetUnpackedValueOfValueDelegate = new System.Action<UnpackingContext, System.DateTime>(this.SetUnpackedValueOfValue);
            this.this_UnpackValueOfValueDelegate = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfValue);
        }
        
        private void PackValueOfValue(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor(unpackingContext.Value);
            return result;
        }
        
        private void SetUnpackedValueOfValue(UnpackingContext unpackingContext, System.DateTime unpackedValue) {
            unpackingContext.Value = unpackedValue;
        }
        
        private void UnpackValueOfValue(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.DateTime), "Value", null, this.this_SetUnpackedValueOfValueDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ValueReadOnlyFieldAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.DateTime ctorArg0 = default(System.DateTime);
            ctorArg0 = default(System.DateTime);
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._unpackOperationTable);
            }
        }
        
        public class UnpackingContext {
            
            public System.DateTime Value;
            
            public UnpackingContext(System.DateTime Value) {
                this.Value = Value;
            }
        }
    }
}
