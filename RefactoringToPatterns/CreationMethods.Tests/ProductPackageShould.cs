using Xunit;

namespace RefactoringToPatterns.CreationMethods.Tests
{
    public class ProductPackageShould
    {
        [Fact]
        public void CreateAProductPackageWithOnlyInternet()
        {
            var productPackage = new ProductPackage("100MB");

            Assert.True(productPackage.HasInternet());
            Assert.False(productPackage.HasVOIP());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndVoip()
        {
            var productPackage = new ProductPackage("100MB", 91233788);

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasVOIP());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndTv()
        {
            var productPackage = new ProductPackage("100MB", new[] {"LaLiga", "Estrenos"});

            Assert.True(productPackage.HasInternet());
            Assert.False(productPackage.HasVOIP());
            Assert.True(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetVoipAndTv() {
            var productPackage = new PackageBuilder()
                .WithInternet("100MB")
                .WithVoip(91233788)
                .WithTvChannels(new[] { "LaLiga", "Estrenos" })
                .Build();

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasVOIP());
            Assert.True(productPackage.HasTv());
        }
    }

    public class PackageBuilder {
        private string internetLabel;
        private int voip;
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