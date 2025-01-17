﻿using SimpleInjector;
using SimpleInjector.Lifestyles;
using EnsureThat;
using System;
using System.Threading.Tasks;

namespace DDD.Core.Infrastructure.DependencyInjection
{
    using Application;
    using Domain;
    using Threading;

    /// <summary>
    /// A decorator that defines a scope around the asynchronous execution of a command.
    /// </summary>
    public class AsyncScopedCommandHandler<TCommand, TContext> : IAsyncCommandHandler<TCommand, TContext>
        where TCommand : class, ICommand
        where TContext : BoundedContext
    {

        #region Fields

        private readonly Container container;
        private readonly Func<IAsyncCommandHandler<TCommand, TContext>> handlerProvider;

        #endregion Fields

        #region Constructors

        public AsyncScopedCommandHandler(Func<IAsyncCommandHandler<TCommand, TContext>> handlerProvider, Container container)
        {
            Ensure.That(handlerProvider, nameof(handlerProvider)).IsNotNull();
            Ensure.That(container, nameof(container)).IsNotNull();
            this.handlerProvider = handlerProvider;
            this.container = container;
        }

        #endregion Constructors

        #region Properties

        public TContext Context => this.handlerProvider().Context;

        #endregion Properties

        #region Methods

        public async Task HandleAsync(TCommand command, IMessageContext context)
        {
            await new SynchronizationContextRemover();
            using (AsyncScopedLifestyle.BeginScope(container))
            {
                var handler = this.handlerProvider();
                await handler.HandleAsync(command, context);
            }
        }

        #endregion Methods

    }
}
