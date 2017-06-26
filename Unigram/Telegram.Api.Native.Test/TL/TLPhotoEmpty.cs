// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLPhotoEmpty : TLPhotoBase 
	{
		public TLPhotoEmpty() { }
		public TLPhotoEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PhotoEmpty; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt64(Id);
		}
	}
}