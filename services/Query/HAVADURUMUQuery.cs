using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.tables;
using MediatR;
using data.uows;
using Microsoft.EntityFrameworkCore;

namespace services.Query
{
    public class HAVADURUMUQuery: IRequest<List<HAVADURUMU>>
    {
        //public int id {get;set;}

        public class Handler : IRequestHandler<HAVADURUMUQuery,List<HAVADURUMU>>
        {
            public async Task<List<HAVADURUMU>> Handle(HAVADURUMUQuery request, CancellationToken cancellationToken)
            {
                var uow = new BlogUnitOfWork();
                var HAVADURUMU = await uow.HAVADURUMURepository.GetQuery()
                .ToListAsync();
                return HAVADURUMU;
            }
        }
    }
}