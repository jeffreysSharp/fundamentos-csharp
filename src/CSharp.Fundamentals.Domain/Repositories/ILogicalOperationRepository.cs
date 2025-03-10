﻿using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface ILogicalOperationRepository
    {
        void Add(LogicalOperation operation);
        IEnumerable<LogicalOperation> GetAll();
        LogicalOperation? GetById(Guid id);
    }
}
