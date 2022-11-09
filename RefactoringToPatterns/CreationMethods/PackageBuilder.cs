namespace RefactoringToPatterns.CreationMethods {
    public class PackageBuilder {
        private string internetLabel;
        private int? voip;
        private string[] tvChannels;

        public PackageBuilder WithInternet(string internetLabel) {
            this.internetLabel = internetLabel;
            return this;
        }

        public PackageBuilder WithVoip(int voip) {
            this.voip = voip;
            return this;
        }

        public PackageBuilder WithTvChannels(string[] tvChannels) {
            this.tvChannels = tvChannels;
            return this;
        }

        public ProductPackage Build() {
            return ProductPackage.CreatePackage(internetLabel,voip,tvChannels);
        }
    }
}