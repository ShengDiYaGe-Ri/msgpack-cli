﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWritePropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty> this_PackValueOfTuple7AllPolymorphicDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>> _packOperationTable;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfTuple7AllPolymorphicAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>> this_SetUnpackedValueOfTuple7AllPolymorphicDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int> this_UnpackValueOfTuple7AllPolymorphicDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfTuple7AllPolymorphicAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWritePropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema0 = new MsgPack.Serialization.PolymorphismSchema[7];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[0] = tupleItemSchema0;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema1 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[1] = tupleItemSchema1;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema2 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema2 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[2] = tupleItemSchema2;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema3 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema3 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[3] = tupleItemSchema3;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema4 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema4 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[4] = tupleItemSchema4;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema5 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema5 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[5] = tupleItemSchema5;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema6 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema6 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[6] = tupleItemSchema6;
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>), tupleItemsSchema0);
            this._serializer0 = context.GetSerializer<System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>(this.PackValueOfTuple7AllPolymorphic);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTuple7AllPolymorphicAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>>(1);
            packOperationTable["Tuple7AllPolymorphic"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>(this.PackValueOfTuple7AllPolymorphic);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["Tuple7AllPolymorphic"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTuple7AllPolymorphicAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int>(this.UnpackValueOfTuple7AllPolymorphic);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTuple7AllPolymorphicAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int>>(1);
            unpackOperationTable["Tuple7AllPolymorphic"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int>(this.UnpackValueOfTuple7AllPolymorphic);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["Tuple7AllPolymorphic"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTuple7AllPolymorphicAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "Tuple7AllPolymorphic"};
            this.this_PackValueOfTuple7AllPolymorphicDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>(this.PackValueOfTuple7AllPolymorphic);
            this.this_PackValueOfTuple7AllPolymorphicAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTuple7AllPolymorphicAsync);
            this.this_SetUnpackedValueOfTuple7AllPolymorphicDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>>(this.SetUnpackedValueOfTuple7AllPolymorphic);
            this.this_UnpackValueOfTuple7AllPolymorphicDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int>(this.UnpackValueOfTuple7AllPolymorphic);
            this.this_UnpackValueOfTuple7AllPolymorphicAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTuple7AllPolymorphicAsync);
        }
        
        private void PackValueOfTuple7AllPolymorphic(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple7AllPolymorphic);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfTuple7AllPolymorphicAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Tuple7AllPolymorphic, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(packer, objectTree, this._packOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(packer, objectTree, this._packOperationTableAsync, cancellationToken);
            }
        }
        
        private void SetUnpackedValueOfTuple7AllPolymorphic(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty unpackingContext, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> unpackedValue) {
            unpackingContext.Tuple7AllPolymorphic = unpackedValue;
        }
        
        private void UnpackValueOfTuple7AllPolymorphic(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>), "Tuple7AllPolymorphic", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTuple7AllPolymorphicDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfTuple7AllPolymorphicAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>), "Tuple7AllPolymorphic", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTuple7AllPolymorphicDelegate, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadWriteProperty>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
