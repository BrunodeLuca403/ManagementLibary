using FluentValidation;
using FluentValidation.AspNetCore;
using Library.Application.Commands.Book;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            service.AddHandlers();
            service.AddValidation();
            return service;
        }

        private static IServiceCollection AddHandlers(this IServiceCollection service)
        {
            service.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<CreateBookCommand>());
            return service;
        }

        private static IServiceCollection AddValidation(this IServiceCollection service)
        {
            service
                .AddFluentValidationAutoValidation()
                .AddValidatorsFromAssemblyContaining<CreateBookCommand>();
            return service;
        }
    }
}
