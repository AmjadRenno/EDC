# EDC Real Estate Management System - API Documentation

## Overview
This document provides detailed API documentation for the EDC Real Estate Management System service classes. These services provide the core business logic and data access functionality.

## Service Interfaces

### ICustomerService Interface

#### Methods

##### GetAllCustomersAsync()
```csharp
Task<List<Customer>> GetAllCustomersAsync()
```
**Description**: Retrieves all customers from the data store.

**Returns**: `Task<List<Customer>>` - List of all customers

**Example**:
```csharp
var customers = await customerService.GetAllCustomersAsync();
foreach (var customer in customers)
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName}");
}
```

##### AddCustomerAsync(Customer customer)
```csharp
Task<bool> AddCustomerAsync(Customer customer)
```
**Description**: Adds a new customer to the data store.

**Parameters**:
- `customer` (Customer): The customer object to add

**Returns**: `Task<bool>` - True if successful, false otherwise

**Validation**:
- FirstName is required
- LastName is required
- Email must be valid format
- Phone is required
- BirthDate must be valid

**Example**:
```csharp
var newCustomer = new Customer
{
    FirstName = "John",
    LastName = "Doe",
    Email = "john.doe@example.com",
    Phone = "12345678",
    BirthDate = new DateTime(1990, 1, 1),
    CustomerType = CustomerType.Buyer
};

var result = await customerService.AddCustomerAsync(newCustomer);
if (result)
{
    Console.WriteLine("Customer added successfully");
}
```

##### SearchCustomersAsync(string searchTerm)
```csharp
Task<List<Customer>> SearchCustomersAsync(string searchTerm)
```
**Description**: Searches customers by name, email, or phone.

**Parameters**:
- `searchTerm` (string): The search term to match against

**Returns**: `Task<List<Customer>>` - List of matching customers

**Search Fields**:
- FirstName
- LastName
- Email
- Phone

**Example**:
```csharp
var results = await customerService.SearchCustomersAsync("John");
```

##### GetCustomersByTypeAsync(CustomerType type)
```csharp
Task<List<Customer>> GetCustomersByTypeAsync(CustomerType type)
```
**Description**: Retrieves customers filtered by type.

**Parameters**:
- `type` (CustomerType): The customer type to filter by

**Returns**: `Task<List<Customer>>` - List of customers of specified type

**Example**:
```csharp
var buyers = await customerService.GetCustomersByTypeAsync(CustomerType.Buyer);
```

### IPropertyService Interface

#### Methods

##### GetAllPropertiesAsync()
```csharp
Task<List<Property>> GetAllPropertiesAsync()
```
**Description**: Retrieves all properties from the data store.

**Returns**: `Task<List<Property>>` - List of all properties

**Example**:
```csharp
var properties = await propertyService.GetAllPropertiesAsync();
```

##### AddPropertyAsync(Property property)
```csharp
Task<bool> AddPropertyAsync(Property property)
```
**Description**: Adds a new property to the data store.

**Parameters**:
- `property` (Property): The property object to add

**Returns**: `Task<bool>` - True if successful, false otherwise

**Validation**:
- Title is required
- Price must be greater than 0
- Size must be greater than 0
- Address is required
- City is required

**Automatic Calculations**:
- PricePerM2 is calculated automatically

**Example**:
```csharp
var newProperty = new Property
{
    Title = "Beautiful Villa",
    PropertyType = PropertyType.Villa,
    Price = 2500000,
    Size = 150,
    Address = "Example Street 123",
    City = "Copenhagen",
    Rooms = 5,
    Bedrooms = 3,
    Bathrooms = 2,
    YearBuilt = 2020
};

var result = await propertyService.AddPropertyAsync(newProperty);
```

##### SearchPropertiesAsync(string searchTerm)
```csharp
Task<List<Property>> SearchPropertiesAsync(string searchTerm)
```
**Description**: Searches properties by title, address, city, or description.

**Parameters**:
- `searchTerm` (string): The search term to match against

**Returns**: `Task<List<Property>>` - List of matching properties

**Search Fields**:
- Title
- Address
- City
- Description

##### FilterPropertiesAsync(PropertyFilterCriteria criteria)
```csharp
Task<List<Property>> FilterPropertiesAsync(PropertyFilterCriteria criteria)
```
**Description**: Filters properties based on multiple criteria.

**Parameters**:
- `criteria` (PropertyFilterCriteria): Filter criteria object

**PropertyFilterCriteria Properties**:
```csharp
public class PropertyFilterCriteria
{
    public PropertyType? PropertyType { get; set; }
    public PropertyStatus? Status { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public int? MinSize { get; set; }
    public int? MaxSize { get; set; }
    public string? City { get; set; }
}
```

**Example**:
```csharp
var criteria = new PropertyFilterCriteria
{
    PropertyType = PropertyType.Villa,
    MinPrice = 1000000,
    MaxPrice = 3000000,
    Status = PropertyStatus.Available
};

var filteredProperties = await propertyService.FilterPropertiesAsync(criteria);
```

### IRealtorService Interface

#### Methods

##### GetAllRealtorsAsync()
```csharp
Task<List<DbRealtors>> GetAllRealtorsAsync()
```
**Description**: Retrieves all realtors from the data store.

**Returns**: `Task<List<DbRealtors>>` - List of all realtors

##### AddRealtorAsync(DbRealtors realtor)
```csharp
Task<bool> AddRealtorAsync(DbRealtors realtor)
```
**Description**: Adds a new realtor to the data store.

**Parameters**:
- `realtor` (DbRealtors): The realtor object to add

**Returns**: `Task<bool>` - True if successful, false otherwise

**Validation**:
- Name is required
- Email must be valid format
- Phone is required

##### UpdateRealtorAsync(DbRealtors realtor)
```csharp
Task<bool> UpdateRealtorAsync(DbRealtors realtor)
```
**Description**: Updates an existing realtor.

**Parameters**:
- `realtor` (DbRealtors): The realtor object with updated information

**Returns**: `Task<bool>` - True if successful, false otherwise

##### DeleteRealtorAsync(int realtorId)
```csharp
Task<bool> DeleteRealtorAsync(int realtorId)
```
**Description**: Deletes a realtor from the data store.

**Parameters**:
- `realtorId` (int): The ID of the realtor to delete

**Returns**: `Task<bool>` - True if successful, false otherwise

##### SearchRealtorsAsync(string searchTerm)
```csharp
Task<List<DbRealtors>> SearchRealtorsAsync(string searchTerm)
```
**Description**: Searches realtors by name, email, or phone.

**Parameters**:
- `searchTerm` (string): The search term to match against

**Returns**: `Task<List<DbRealtors>>` - List of matching realtors

## Data Models

### Customer Model
```csharp
public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public CustomerType CustomerType { get; set; }
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    
    // Calculated Properties
    public int Age { get; }
    public string FullName { get; }
    public string CustomerTypeDisplay { get; }
}
```

### Property Model
```csharp
public class Property
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public PropertyType PropertyType { get; set; }
    public PropertyStatus Status { get; set; }
    public decimal Price { get; set; }
    public int Size { get; set; } // in square meters
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public int Rooms { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int YearBuilt { get; set; }
    public string Description { get; set; } = string.Empty;
    
    // Calculated Properties
    public decimal PricePerM2 { get; }
    public string FormattedPrice { get; }
    public string FormattedPricePerM2 { get; }
    public string PropertyTypeDisplay { get; }
    public string StatusDisplay { get; }
}
```

### DbRealtors Model
```csharp
public class DbRealtors
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}
```

## Enumerations

### CustomerType
```csharp
public enum CustomerType
{
    Buyer = 0,   // Køber
    Seller = 1   // Sælger
}
```

### PropertyType
```csharp
public enum PropertyType
{
    Villa = 0,        // Villa
    Apartment = 1,    // Lejlighed
    Townhouse = 2     // Rækkehus
}
```

### PropertyStatus
```csharp
public enum PropertyStatus
{
    Available = 0,    // Ledig
    UnderOffer = 1,   // Under bud
    Reserved = 2      // Reserveret
}
```

## Error Handling

### Common Exception Types
- `ArgumentNullException` - When required parameters are null
- `ValidationException` - When data validation fails
- `FileNotFoundException` - When data files are missing
- `JsonException` - When JSON parsing fails
- `UnauthorizedAccessException` - When file access is denied

### Error Response Pattern
```csharp
try
{
    var result = await service.AddCustomerAsync(customer);
    return result;
}
catch (ValidationException ex)
{
    // Handle validation errors
    ShowError($"Validation error: {ex.Message}");
    return false;
}
catch (Exception ex)
{
    // Handle unexpected errors
    ShowError($"An error occurred: {ex.Message}");
    return false;
}
```

## Performance Considerations

### Async Operations
- All service methods are asynchronous
- Use `await` when calling service methods
- Avoid blocking UI thread

### Caching Strategy
- Services load data once and cache in memory
- Data is refreshed on add/update/delete operations
- Consider implementing cache invalidation for large datasets

### File I/O Optimization
- JSON files are read/written atomically
- Backup files created before writing
- Error recovery mechanisms in place

## Usage Examples

### Complete Customer Workflow
```csharp
// Initialize service
var customerService = new CustomerService();

// Add new customer
var customer = new Customer
{
    FirstName = "Anna",
    LastName = "Hansen",
    Email = "anna@example.com",
    Phone = "12345678",
    BirthDate = new DateTime(1985, 5, 15),
    CustomerType = CustomerType.Buyer,
    Address = "Main Street 123",
    City = "Copenhagen",
    PostalCode = "2100"
};

await customerService.AddCustomerAsync(customer);

// Search customers
var results = await customerService.SearchCustomersAsync("Anna");

// Filter by type
var buyers = await customerService.GetCustomersByTypeAsync(CustomerType.Buyer);
```

### Complete Property Workflow
```csharp
// Initialize service
var propertyService = new PropertyService();

// Add new property
var property = new Property
{
    Title = "Modern Apartment",
    PropertyType = PropertyType.Apartment,
    Status = PropertyStatus.Available,
    Price = 3500000,
    Size = 85,
    Address = "Harbor View 45",
    City = "Copenhagen",
    PostalCode = "2150",
    Rooms = 3,
    Bedrooms = 2,
    Bathrooms = 1,
    YearBuilt = 2019,
    Description = "Beautiful modern apartment with harbor view"
};

await propertyService.AddPropertyAsync(property);

// Filter properties
var criteria = new PropertyFilterCriteria
{
    PropertyType = PropertyType.Apartment,
    MinPrice = 3000000,
    MaxPrice = 4000000,
    Status = PropertyStatus.Available
};

var filtered = await propertyService.FilterPropertiesAsync(criteria);
```

This API documentation provides comprehensive guidance for developers working with the EDC Real Estate Management System services.
