namespace Microsoft.PointOfService
{
    public class HardTotals : Microsoft.PointOfService.PosCommon
    {
        protected HardTotals()
        {
        }
        public const System.Int32 ExtendedErrorNoRoom = 201;
        public const System.Int32 ExtendedErrorValidation = 202;
        public System.Boolean CapErrorDetection
        {
            get { return false; }
        }
        public System.Boolean CapSingleFile
        {
            get { return false; }
        }
        public System.Boolean CapTransactions
        {
            get { return false; }
        }
        public System.Int32 FreeData
        {
            get { return 0; }
        }
        public System.Int32 NumberOfFiles
        {
            get { return 0; }
        }
        public System.Int32 TotalsSize
        {
            get { return 0; }
        }
        public System.Boolean TransactionInProgress
        {
            get { return false; }
        }
        public virtual void BeginTrans()
        {
        }
        public virtual void ClaimFile(System.Int32 param_param_handle, System.Int32 param_param_timeout)
        {
        }
        public virtual void CommitTrans()
        {
        }
        public virtual System.Int32 Create(System.String param_param_fileName, System.Int32 param_param_size, System.Boolean param_param_errorDetection)
        {
            return 0;
        }
        public virtual void Delete(System.String param_param_fileName)
        {
        }
        public virtual Microsoft.PointOfService.TotalsFileInfo Find(System.String param_param_fileName)
        {
            return new Microsoft.PointOfService.TotalsFileInfo();
        }
        public virtual System.String FindByIndex(System.Int32 param_param_index)
        {
            return null;
        }
        public virtual System.Byte[] Read(System.Int32 param_param_handle, System.Int32 param_param_offset, System.Int32 param_param_count)
        {
            return null;
        }
        public virtual void RecalculateValidationData(System.Int32 param_param_handle)
        {
        }
        public virtual void ReleaseFile(System.Int32 param_param_handle)
        {
        }
        public virtual void Rename(System.Int32 param_param_handle, System.String param_param_newName)
        {
        }
        public virtual void Rollback()
        {
        }
        public virtual void SetAll(System.Int32 param_param_handle, System.Byte param_param_targetValue)
        {
        }
        public virtual void ValidateData(System.Int32 param_param_handle)
        {
        }
        public virtual void Write(System.Int32 param_param_handle, System.Byte[] param_param_data, System.Int32 param_param_offset)
        {
        }
    }
}
