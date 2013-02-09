namespace Microsoft.PointOfService
{
    public abstract class HardTotals : Microsoft.PointOfService.PosCommon
    {
        protected HardTotals()
        {
        }
        public const System.Int32 ExtendedErrorNoRoom = 201;
        public const System.Int32 ExtendedErrorValidation = 202;
        public abstract System.Boolean CapErrorDetection { get; }
        public abstract System.Boolean CapSingleFile { get; }
        public abstract System.Boolean CapTransactions { get; }
        public abstract System.Int32 FreeData { get; }
        public abstract System.Int32 NumberOfFiles { get; }
        public abstract System.Int32 TotalsSize { get; }
        public abstract System.Boolean TransactionInProgress { get; }
        public virtual void BeginTrans()
        {
        }
        
        public virtual void ClaimFile(System.Int32 handle, System.Int32 timeout)
        {
        }
        
        public virtual void CommitTrans()
        {
        }
        
        public virtual System.Int32 Create(System.String fileName, System.Int32 size, System.Boolean errorDetection)
        {
            return 0;
        }
        
        public virtual void Delete(System.String fileName)
        {
        }
        
        public virtual Microsoft.PointOfService.TotalsFileInfo Find(System.String fileName)
        {
            return new Microsoft.PointOfService.TotalsFileInfo();
        }
        
        public virtual System.String FindByIndex(System.Int32 index)
        {
            return null;
        }
        
        public virtual System.Byte[] Read(System.Int32 handle, System.Int32 offset, System.Int32 count)
        {
            return null;
        }
        
        public virtual void RecalculateValidationData(System.Int32 handle)
        {
        }
        
        public virtual void ReleaseFile(System.Int32 handle)
        {
        }
        
        public virtual void Rename(System.Int32 handle, System.String newName)
        {
        }
        
        public virtual void Rollback()
        {
        }
        
        public virtual void SetAll(System.Int32 handle, System.Byte targetValue)
        {
        }
        
        public virtual void ValidateData(System.Int32 handle)
        {
        }
        
        public virtual void Write(System.Int32 handle, System.Byte[] data, System.Int32 offset)
        {
        }
        
    }
}
