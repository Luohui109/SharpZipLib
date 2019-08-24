namespace ICSharpCode.SharpZipLib.Zip
{
	/// <summary>
	/// The method of encrypting entries when creating zip archives.
	/// </summary>
	public enum ZipEncryptionMethod
	{
		/// <summary>
		/// Encrypt entries with ZipCrypto.
		/// </summary>
		ZipCrypto,

		/// <summary>
		/// Encrypt entries with AES 128.
		/// </summary>
		AES128,

		/// <summary>
		/// Encrypt entries with AES 256.
		/// </summary>
		AES256
	}
}
