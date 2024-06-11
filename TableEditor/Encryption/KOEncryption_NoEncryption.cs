namespace TableEditor.Encryption
{
    class KOEncryptionNoEncryption : KOEncryptionBase
    {
        public override string Name()
        {
            return "Not encrypted (plain)";
        }

        public override string Description()
        {
            return "Plain table without encryption.";
        }

        public override void Decode(ref byte[] data)
        {
            return;}

        public override void Encode(FileStream plainStream)
        {
            // noop
        }

        public override bool NewTableStructure()
        {
            return false;
        }
    }
}
