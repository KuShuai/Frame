// automatically generated by the FlatBuffers compiler, do not modify

package AutoGenConfig

import (
	flatbuffers "github.com/google/flatbuffers/go"
)

type Sheet1Config struct {
	_tab flatbuffers.Table
}

func GetRootAsSheet1Config(buf []byte, offset flatbuffers.UOffsetT) *Sheet1Config {
	n := flatbuffers.GetUOffsetT(buf[offset:])
	x := &Sheet1Config{}
	x.Init(buf, n+offset)
	return x
}

func (rcv *Sheet1Config) Init(buf []byte, i flatbuffers.UOffsetT) {
	rcv._tab.Bytes = buf
	rcv._tab.Pos = i
}

func (rcv *Sheet1Config) Table() flatbuffers.Table {
	return rcv._tab
}

func (rcv *Sheet1Config) Data(obj *SingleSheet1ConfigData, j int) bool {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(4))
	if o != 0 {
		x := rcv._tab.Vector(o)
		x += flatbuffers.UOffsetT(j) * 4
		x = rcv._tab.Indirect(x)
		obj.Init(rcv._tab.Bytes, x)
		return true
	}
	return false
}

func (rcv *Sheet1Config) DataLength() int {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(4))
	if o != 0 {
		return rcv._tab.VectorLen(o)
	}
	return 0
}

func Sheet1ConfigStart(builder *flatbuffers.Builder) {
	builder.StartObject(1)
}
func Sheet1ConfigAddData(builder *flatbuffers.Builder, data flatbuffers.UOffsetT) {
	builder.PrependUOffsetTSlot(0, flatbuffers.UOffsetT(data), 0)
}
func Sheet1ConfigStartDataVector(builder *flatbuffers.Builder, numElems int) flatbuffers.UOffsetT {
	return builder.StartVector(4, numElems, 4)
}
func Sheet1ConfigEnd(builder *flatbuffers.Builder) flatbuffers.UOffsetT {
	return builder.EndObject()
}
