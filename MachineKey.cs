//////////////////////////////////////////////////////////////////////////////
// This source code and all associated files and resources are copyrighted by
// the author(s). This source code and all associated files and resources may
// be used as long as they are used according to the terms and conditions set
// forth in The Code Project Open License (CPOL).
//
// Copyright (c) 2011 Jonathan Wood
//

using System.Security.Cryptography;
using System.Text;

namespace BlackBeltCoder
{
	/// <summary>
	/// Version arguments to MachineKey.Generate() method.
	/// </summary>
	public enum MachineKeyVersion
	{
		/// <summary>
		/// .NET version 1.1.
		/// </summary>
		Net1,

		/// <summary>
		/// .NET version 2.0 and up.
		/// </summary>
		Net2,
	}

	public class MachineKey
	{
		/// <summary>
		/// Generates the contents of a machineKey element suitable for use in
		/// an ASP.NET web.config file.
		/// </summary>
		/// <param name="version">Indicates if keys should be generated for
		/// ASP.NET 1.1 or 2.0 and later.</param>
		public static string Generate(MachineKeyVersion version)
		{
			// Generate keys
			string validationKey = GenerateKey(64);
			string decryptionKey;
			if (version == MachineKeyVersion.Net1)
				decryptionKey = GenerateKey(24);
			else
				decryptionKey = GenerateKey(32);

			// Construct <machineKey> tag
			StringBuilder builder = new StringBuilder();
			builder.Append("<machineKey");
			builder.AppendFormat(" validationKey=\"{0}\"", validationKey);
			builder.AppendFormat(" decryptionKey=\"{0}\"", decryptionKey);
			builder.Append(" validation=\"SHA1\"");
			if (version == MachineKeyVersion.Net2)
				builder.Append(" decryption=\"AES\"");
			builder.Append(" />");
			return builder.ToString();
		}

		/// <summary>
		/// Generates a string of random hex digits of the specified
		/// number of bytes.
		/// </summary>
		/// <param name="length">Number of bytes to generate</param>
		protected static string GenerateKey(int length)
		{
			RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
			byte[] buff = new byte[length];
			rngCsp.GetBytes(buff);
			StringBuilder sb = new StringBuilder(buff.Length * 2);
			for (int i = 0; i < buff.Length; i++)
				sb.Append(string.Format("{0:X2}", buff[i]));
			return sb.ToString();
		}
	}
}
