// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace AutoGenConfig
{

using global::System;
using global::FlatBuffers;

public struct TestConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static TestConfig GetRootAsTestConfig(ByteBuffer _bb) { return GetRootAsTestConfig(_bb, new TestConfig()); }
  public static TestConfig GetRootAsTestConfig(ByteBuffer _bb, TestConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool TestConfigBufferHasIdentifier(ByteBuffer _bb) { return Table.__has_identifier(_bb, "WHAT"); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public TestConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public SingleTestConfigData? Data(int j) { int o = __p.__offset(4); return o != 0 ? (SingleTestConfigData?)(new SingleTestConfigData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<TestConfig> CreateTestConfig(FlatBufferBuilder builder,
      VectorOffset dataOffset = default(VectorOffset)) {
    builder.StartObject(1);
    TestConfig.AddData(builder, dataOffset);
    return TestConfig.EndTestConfig(builder);
  }

  public static void StartTestConfig(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddData(FlatBufferBuilder builder, VectorOffset dataOffset) { builder.AddOffset(0, dataOffset.Value, 0); }
  public static VectorOffset CreateDataVector(FlatBufferBuilder builder, Offset<SingleTestConfigData>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<TestConfig> EndTestConfig(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<TestConfig>(o);
  }
  public static void FinishTestConfigBuffer(FlatBufferBuilder builder, Offset<TestConfig> offset) { builder.Finish(offset.Value, "WHAT"); }
};

public struct SingleTestConfigData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static SingleTestConfigData GetRootAsSingleTestConfigData(ByteBuffer _bb) { return GetRootAsSingleTestConfigData(_bb, new SingleTestConfigData()); }
  public static SingleTestConfigData GetRootAsSingleTestConfigData(ByteBuffer _bb, SingleTestConfigData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public SingleTestConfigData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int ID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Data1 { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetData1Bytes() { return __p.__vector_as_arraysegment(6); }
  public int Data2 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<SingleTestConfigData> CreateSingleTestConfigData(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset data1Offset = default(StringOffset),
      int data2 = 0) {
    builder.StartObject(3);
    SingleTestConfigData.AddData2(builder, data2);
    SingleTestConfigData.AddData1(builder, data1Offset);
    SingleTestConfigData.AddID(builder, ID);
    return SingleTestConfigData.EndSingleTestConfigData(builder);
  }

  public static void StartSingleTestConfigData(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddData1(FlatBufferBuilder builder, StringOffset data1Offset) { builder.AddOffset(1, data1Offset.Value, 0); }
  public static void AddData2(FlatBufferBuilder builder, int data2) { builder.AddInt(2, data2, 0); }
  public static Offset<SingleTestConfigData> EndSingleTestConfigData(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<SingleTestConfigData>(o);
  }
};


}
