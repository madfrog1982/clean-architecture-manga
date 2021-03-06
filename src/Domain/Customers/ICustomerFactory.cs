namespace Domain.Customers
{
    using Domain.Customers.ValueObjects;

    /// <summary>
    /// Customer <see href="https://github.com/ivanpaulovich/clean-architecture-manga/wiki/Domain-Driven-Design-Patterns#entity-factory">Entity Factory Domain-Driven Design Pattern</see>.
    /// </summary>
    public interface ICustomerFactory
    {
        /// <summary>
        /// Creates a new Customer.
        /// </summary>
        /// <param name="ssn">SSN.</param>
        /// <param name="name">Name.</param>
        /// <returns>New Customer instance.</returns>
        ICustomer NewCustomer(SSN ssn, Name name);
    }
}
