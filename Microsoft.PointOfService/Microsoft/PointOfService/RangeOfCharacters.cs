namespace Microsoft.PointOfService
{
    public class RangeOfCharacters
    {
        public RangeOfCharacters(System.Char singleCharacter)
        {
        }
        
        public RangeOfCharacters(System.Char fromCharacter, System.Char toCharacter)
        {
        }
        
        protected RangeOfCharacters()
        {
        }
        public System.Char From { get { return '\0'; } set { } }
        public System.Char To { get { return '\0'; } set { } }
        public override System.String ToString()
        {
            return null;
        }
        
    }
}
