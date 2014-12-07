using System;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public abstract class ExternalRsaKeyParameters
        : RsaKeyParameters
    {
        public ExternalRsaKeyParameters(
            BigInteger modulus,
            BigInteger exponent)
            : base(true, modulus, exponent)
        {
        }

        public abstract byte[] PrivateSign(byte[] buffer, int offset, int length);
        public abstract byte[] PrivateDecrypt(byte[] buffer, int offset, int length);
    }
}
