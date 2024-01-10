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
    public class AddHAVADURUMUCommand: IRequest<HAVADURUMU>
    {
        public HAVADURUMU HAVA {get;set;}

        public class Handler : IRequestHandler<AddHAVADURUMUCommand,HAVADURUMU>
        {
            public async Task<HAVADURUMU> Handle(AddHAVADURUMUCommand request, CancellationToken cancellationToken)
            {
                return await Task.Factory.StartNew( () => {
                    var uow = new BlogUnitOfWork();
                    var HAVADURUMU = uow.HAVADURUMURepository.Add(request.HAVA);
                    uow.HAVADURUMURepository.Save();
                    return HAVADURUMU;
                });
               
            }

            
        }
    }
}