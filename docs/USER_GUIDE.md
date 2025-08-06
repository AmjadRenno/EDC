# EDC Real Estate Management System - User Guide

## Getting Started

Welcome to the EDC Real Estate Management System! This comprehensive guide will help you navigate and use all features of the application effectively.

## System Requirements

- Windows 10 or Windows 11
- .NET 8.0 Runtime (installed automatically)
- Minimum 4 GB RAM
- 100 MB free disk space

## Installation

1. Download the latest release from GitHub
2. Extract the files to your desired location
3. Run `EDC.exe` to start the application
4. The system will create necessary data folders automatically

## Main Interface

### Start View
The main dashboard provides access to all system modules:

- **🏢 Mæglere** - Realtor Management
- **👥 Kunder** - Customer Management  
- **🏠 Boliger** - Property Management

## Realtor Management (Mæglere)

### Adding a New Realtor
1. Click **"🏢 Mæglere"** from the main menu
2. Select **"📝 Opret ny mægler"**
3. Fill in the required information:
   - **Navn** (Name) - Required
   - **Email** - Must be valid email format
   - **Telefon** (Phone) - Required
   - **Adresse** (Address) - Optional
4. Click **"Opret ny mægler"** to save

### Viewing Realtors
1. From Mæglere menu, select **"👥 Se mæglere"**
2. Browse the complete list of realtors
3. Use the search box to find specific realtors
4. Search filters:
   - Name
   - Email
   - Phone number

### Editing Realtors
1. In the realtors list, select a realtor
2. Click **"Rediger"** (Edit)
3. Modify the information
4. Click **"Opdater mægler"** to save changes

### Deleting Realtors
1. In the realtors list, select a realtor
2. Click **"Slet"** (Delete)
3. Confirm the deletion in the dialog
4. The realtor will be permanently removed

## Customer Management (Kunder)

### Customer Types
The system supports two customer types:
- **Køber** (Buyer) - Customers looking to purchase properties
- **Sælger** (Seller) - Customers looking to sell properties

### Adding a New Customer
1. Click **"👥 Kunder"** from the main menu
2. Select **"👤 Ny kunde"**
3. Choose customer type (Køber/Sælger)
4. Fill in customer information:
   - **Fornavn** (First Name) - Required
   - **Efternavn** (Last Name) - Required
   - **Email** - Must be valid format
   - **Telefon** (Phone) - Required
   - **Fødselsdato** (Birth Date) - Age calculated automatically
   - **Adresse** (Address) - Complete address details
5. Click **"Opret kunde"** to save

### Viewing Customers
1. From Kunder menu, select **"👥 Se kunder"**
2. View all customers in the data grid
3. Filter options:
   - **Alle** - Show all customers
   - **Køber** - Show only buyers
   - **Sælger** - Show only sellers
4. Use search functionality to find specific customers

### Customer Information Display
The customer list shows:
- Full name
- Customer type
- Age (calculated from birth date)
- Contact information
- Complete address

## Property Management (Boliger)

### Property Types
Supported property types:
- **Villa** - Detached houses
- **Lejlighed** - Apartments/Condominiums
- **Rækkehus** - Townhouses

### Property Status
- **Ledig** (Available) - Property is available for sale
- **Under bud** (Under Offer) - Offer has been made
- **Reserveret** (Reserved) - Property is reserved

### Adding a New Property
1. Click **"🏠 Boliger"** from the main menu
2. Select **"🏠 Ny bolig"**
3. Fill in property details:

   **Basic Information:**
   - **Titel** (Title) - Property title/name
   - **Type** - Select property type
   - **Status** - Current availability status
   - **Pris** (Price) - Property price in DKK
   - **Størrelse** (Size) - Size in square meters

   **Location Details:**
   - **Adresse** (Address) - Street address
   - **By** (City) - City name
   - **Postnummer** (Postal Code) - ZIP code

   **Property Features:**
   - **Værelser** (Rooms) - Number of rooms
   - **Soveværelser** (Bedrooms) - Number of bedrooms
   - **Badeværelser** (Bathrooms) - Number of bathrooms
   - **Byggeår** (Year Built) - Construction year

   **Additional Information:**
   - **Beskrivelse** (Description) - Detailed property description

4. The system automatically calculates **Pris pr. m²** (Price per square meter)
5. Click **"Opret bolig"** to save

### Viewing Properties
1. From Boliger menu, select **"🏘️ Se boliger"**
2. Browse all properties in the data grid
3. Advanced filtering options:

   **Type Filter:**
   - Alle (All)
   - Villa
   - Lejlighed
   - Rækkehus

   **Status Filter:**
   - Alle (All)
   - Ledig (Available)
   - Under bud (Under Offer)
   - Reserveret (Reserved)

   **Price Range Filter:**
   - Minimum price
   - Maximum price

   **Size Filter:**
   - Minimum size (m²)
   - Maximum size (m²)

4. Use the search box for quick property lookup

### Property Information Display
The property grid shows:
- Property title and type
- Price (formatted in DKK)
- Price per square meter
- Size and room count
- Location (city)
- Current status

## Data Management

### Automatic Saving
- All data is saved automatically when you create, edit, or delete records
- No manual save operation required
- Data is immediately persisted to local files

### Data Location
Your data is stored locally in:
```
%APPDATA%\EDC\
├── customers.json    - Customer data
├── properties.json   - Property data
└── realtors.json     - Realtor data
```

### Backup Recommendations
1. Regular backups of the `%APPDATA%\EDC\` folder
2. Copy JSON files to external storage
3. Use cloud storage for automatic backup

## Search and Filtering

### Global Search Features
- Real-time search as you type
- Case-insensitive matching
- Multiple field search
- Instant results

### Realtor Search
Search across:
- Name
- Email address
- Phone number

### Customer Search
Search across:
- First name
- Last name
- Email address
- Phone number

### Property Search
Search across:
- Property title
- Address
- City
- Description

## Tips and Best Practices

### Data Entry Tips
1. **Consistent Format**: Use consistent formatting for phone numbers and addresses
2. **Complete Information**: Fill in as much information as possible for better tracking
3. **Valid Email**: Ensure email addresses are properly formatted
4. **Price Accuracy**: Double-check property prices before saving

### Navigation Tips
1. **Back Button**: Use the back arrow to return to previous screens
2. **Main Menu**: Click the EDC logo to return to the main dashboard
3. **Form Navigation**: Tab through fields for efficient data entry

### Performance Tips
1. **Search Efficiency**: Use specific search terms for faster results
2. **Large Datasets**: Filter data before browsing large lists
3. **Regular Cleanup**: Remove outdated records periodically

## Troubleshooting

### Common Issues

**Application Won't Start**
- Ensure .NET 8.0 is installed
- Check if EDC.exe is blocked by antivirus
- Run as administrator if needed

**Data Not Saving**
- Check if %APPDATA% folder is accessible
- Ensure sufficient disk space
- Verify file permissions

**Search Not Working**
- Try clearing search terms and re-entering
- Check if data exists in the system
- Restart the application

**Forms Not Displaying Correctly**
- Check Windows display scaling settings
- Update graphics drivers
- Try running in compatibility mode

### Error Messages
The system provides clear error messages for common issues:
- Validation errors highlight specific fields
- File access errors suggest solutions
- Network errors provide retry options

## Keyboard Shortcuts

### General Navigation
- **Tab** - Move to next field
- **Shift + Tab** - Move to previous field
- **Enter** - Activate default button
- **Escape** - Cancel/close dialog

### Form Shortcuts
- **Ctrl + S** - Save (when available)
- **Ctrl + N** - New record (when available)
- **F5** - Refresh data

## Support and Contact

For additional support:
1. Check the troubleshooting section above
2. Review the GitHub repository documentation
3. Submit issues on GitHub for bug reports
4. Contact the development team for technical support

## System Updates

### Checking for Updates
- Updates are distributed through GitHub releases
- Download the latest version manually
- Replace existing files with new version

### Update Process
1. Close the EDC application
2. Download the latest release
3. Extract files to the installation directory
4. Restart the application
5. Verify data integrity after update

---

**EDC Real Estate Management System** - Making property management simple and efficient.
