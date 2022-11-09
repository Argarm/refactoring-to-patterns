using Xunit;

namespace RefactoringToPatterns.CreationMethods.Tests
{
    public class ProductPackageShould
    {
        [Fact]
        public void CreateAProductPackageWithOnlyInternet()
        {
            var productPackage = new PackageBuilder()
                .WithInternet("100MB")
                .Build();

            Assert.True(productPackage.HasInternet());
            Assert.False(productPackage.HasVOIP());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndVoip() {
            var productPackage = new PackageBuilder()
                .WithInternet("100MB")
                .WithVoip(91233788)
                .Build();

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasVOIP());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndTv() {
            var productPackage = new PackageBuilder()
                .WithInternet("100MB")
                .WithTvChannels(new[] { "LaLiga", "Estrenos" })
                .Build();

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
}