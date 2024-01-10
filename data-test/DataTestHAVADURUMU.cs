using data.tables;
using services.Query;

namespace data_test;

public class DataTestHAVADURUMU
{
    [Fact]
    public async void Test2()
    {
        var HAVADURUMUQuery = new HAVADURUMUQuery();
        var datas =  await new HAVADURUMUQuery.Handler().Handle(HAVADURUMUQuery,CancellationToken.None);
        Assert.True( datas != null);
        
        Assert.Collection<HAVADURUMU>(datas,e =>
        {
            Assert.Contains(e.name,"Hava durumu tahmini");
        });
    }
}