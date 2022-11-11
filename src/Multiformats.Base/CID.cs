using System;
namespace Multiformats.Base
{
	public class CID : Multibase
	{
		public CID()
		{
		}

        protected override string Name => "cidv1";

        protected override char Prefix => throw new NotImplementedException();

        protected override char[] Alphabet => throw new NotImplementedException();

        public override byte[] Decode(string input)
        {
            throw new NotImplementedException();
        }

        public override string Encode(byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }
}

