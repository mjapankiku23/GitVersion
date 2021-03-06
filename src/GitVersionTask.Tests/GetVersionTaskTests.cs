using System.Linq;
using GitVersion;
using GitVersionTask;
using NUnit.Framework;
using Shouldly;

[TestFixture]
public class GetVersionTaskTests : TestBase
{
    [Test]
    public void OutputsShouldMatchVariableProvider()
    {
        var taskProperties = typeof(GetVersion.Output)
            .GetProperties()
            .Select(p => p.Name);

        var variablesProperties = VersionVariables.AvailableVariables;

        taskProperties.ShouldBe(variablesProperties, ignoreOrder: true);
    }
}
