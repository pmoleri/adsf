using Bunit;
using Microsoft.Extensions.DependencyInjection;
using UntitledApp27.Pages;
using UntitledApp27.Financial;

namespace TestUntitledApp27
{
	[Collection("UntitledApp27")]
	public class TestMaster_View
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbComboModule),
				typeof(IgbSnackbarModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<Master_View>();
			Assert.NotNull(componentUnderTest);
		}
	}
}