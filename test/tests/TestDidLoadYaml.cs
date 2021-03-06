using DPMLib;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace test
{
  public class TestDidLoadYaml
  {
    private readonly ITestOutputHelper output;
    private List<MappedDataSet> mappings;
    //private FilteredMappings mappings;

    public TestDidLoadYaml(ITestOutputHelper output)
    {
      this.output = output;
      mappings = YamlLoader.LoadFromFile(@"..\..\..\resources\metadata\sample.yaml");
      //mappings = YamlLoader.LoadFromFolder(@"..\..\..\resources\metadata", "INT");
    }

    /* Start of Tests */

    [Fact]
    public void EnsureLoadedSomething()
    {
      Assert.NotEmpty(mappings);
    }

    // [Fact]
    // public void EnsureValidatesAsJSON()
    // {
    //   ValidationResult result = JsonLoader.ValidateJson(testObject.JSON);
    //   String errmsg = "";
    //   {
    //     // return first exception
    //     var e = result.Errors[0];
    //     errmsg = string.Format("Validation Message: {0} - {1}", e.ErrorType, e.Message);
    //     errmsg = errmsg + string.Format("  - exception at: {0}, {1} - {2}", e.LineNumber, e.LinePosition, e.Path);
    //   }
    //   Assert.True(result.Valid, errmsg);
    // }

    // [Fact]
    // public void DeserialiseSerialiseWithoutChange()
    // {
    //   testObject.SaveToFile("YAML", "/home/scott/development/dw-ecosystem/dw-metadata/dw-meta-lib.test/out/", "SRC1.dbo.REF_DATA1~HSTG.dbo.HSTG_SRC1_REF_DATA1.yaml");
    //   // Assert.True(TODO: file compare);
    // }
  }
}
