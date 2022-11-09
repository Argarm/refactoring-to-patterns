namespace RefactoringToPatterns.CreationMethods
{
    public class ProductPackage
    {
        private readonly string _internetLabel;
        private readonly int? _telephoneNumber;
        private readonly string[] _tvChannels;

        public ProductPackage(string internetLabel, string[] tvChannels)
        {
            _internetLabel = internetLabel;
            _tvChannels = tvChannels;
        }

        public ProductPackage(string internetLabel, int? telephoneNumber, string[] tvChannels)
        {
            _internetLabel = internetLabel;
            _telephoneNumber = telephoneNumber;
            _tvChannels = tvChannels;
        }

        public bool HasInternet()
        {
            return _internetLabel != null;
        }


        public bool HasVOIP()
        {
            return _telephoneNumber != null;
        }

        public bool HasTv()
        {
            return _tvChannels != null;
        }

        public static ProductPackage CreateFullPackage(string internetLabel, int telephoneNumber, string[] tvChannels) {
            return new ProductPackage(internetLabel, telephoneNumber, tvChannels);
        }

        public static ProductPackage CreateSimplePackage(string internetLabel) {
            return new ProductPackage(internetLabel,null, null);
        }

        public static ProductPackage CreateInternetAndVoip(int telephoneNumber, string internetLabel) {
            return new ProductPackage(internetLabel, telephoneNumber, null);
        }
    }
}