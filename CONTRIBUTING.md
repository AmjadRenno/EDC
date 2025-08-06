# Contributing to EDC Real Estate Management System

Thank you for your interest in contributing to the EDC Real Estate Management System! This document provides guidelines for contributing to this project.

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK
- Visual Studio 2022 or VS Code with C# extension
- Git for version control
- Basic understanding of C# and Windows Forms

### Development Setup
1. Fork the repository on GitHub
2. Clone your forked repository locally
3. Create a new branch for your feature/fix
4. Set up your development environment

## 📋 Development Guidelines

### Code Standards
- Follow Microsoft C# Coding Conventions
- Use meaningful variable and method names
- Write comprehensive XML documentation for public methods
- Apply SOLID principles
- Use async/await for I/O operations
- Implement proper error handling

### Architecture
- Follow the existing MVP (Model-View-Presenter) pattern
- Keep business logic in Service classes
- Use interfaces for dependency injection
- Maintain separation of concerns

### UI Guidelines
- Use the existing Material Design theme
- Apply consistent color scheme (EDC corporate colors)
- Ensure Danish language support where applicable
- Follow responsive design principles
- Use custom UI components (ModernButton, ModernTextBox)

## 🔧 Development Process

### 1. Setting Up Your Environment
```bash
git clone https://github.com/yourusername/EDC-RealEstate.git
cd EDC-RealEstate
dotnet restore
dotnet build
```

### 2. Creating a New Feature
1. Create a feature branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```

2. Make your changes following the guidelines above

3. Test your changes thoroughly:
   ```bash
   dotnet build
   dotnet run
   ```

4. Commit your changes:
   ```bash
   git add .
   git commit -m "Add: Description of your feature"
   ```

### 3. Submitting Changes
1. Push your branch to your fork:
   ```bash
   git push origin feature/your-feature-name
   ```

2. Create a Pull Request on GitHub
3. Fill out the Pull Request template
4. Wait for code review and feedback

## 🧪 Testing

### Manual Testing
- Test all CRUD operations for your changes
- Verify UI responsiveness and design consistency
- Test error handling scenarios
- Ensure data persistence works correctly

### Code Quality
- Ensure your code builds without warnings
- Verify that existing functionality still works
- Check for memory leaks in form navigation
- Validate data input/output operations

## 📝 Pull Request Guidelines

### Pull Request Template
When creating a pull request, please include:

1. **Description**: Clear description of what the PR does
2. **Type of Change**: Bug fix, new feature, improvement, etc.
3. **Testing**: How you tested your changes
4. **Screenshots**: If UI changes are involved
5. **Checklist**: Ensure all requirements are met

### Review Process
1. Automated builds must pass
2. Code review by maintainers
3. Testing verification
4. Documentation updates if needed
5. Final approval and merge

## 🐛 Bug Reports

### Reporting Bugs
When reporting bugs, please include:
- Steps to reproduce
- Expected behavior
- Actual behavior
- System information (Windows version, .NET version)
- Screenshots or error messages

### Bug Fix Process
1. Create an issue describing the bug
2. Reference the issue in your PR
3. Include tests to prevent regression
4. Update documentation if needed

## 💡 Feature Requests

### Suggesting Features
1. Check existing issues for similar requests
2. Create a detailed feature request issue
3. Discuss the proposal with maintainers
4. Get approval before implementing

### Implementation
1. Follow the standard development process
2. Include comprehensive tests
3. Update documentation
4. Consider backward compatibility

## 📚 Documentation

### Code Documentation
- Document all public methods and classes
- Include usage examples where appropriate
- Keep documentation up to date with changes

### User Documentation
- Update README.md for new features
- Include usage instructions
- Add screenshots for UI changes

## 🔄 Release Process

### Version Numbering
We follow Semantic Versioning (SemVer):
- MAJOR.MINOR.PATCH
- Major: Breaking changes
- Minor: New features, backward compatible
- Patch: Bug fixes, backward compatible

### Release Checklist
- [ ] All tests pass
- [ ] Documentation updated
- [ ] Version number incremented
- [ ] Release notes prepared
- [ ] Build artifacts created

## 🤝 Community

### Communication
- Use GitHub Issues for bug reports and feature requests
- Be respectful and constructive in discussions
- Help others learn and contribute

### Recognition
Contributors will be recognized in:
- README.md contributors section
- Release notes
- Special recognition for significant contributions

## ⚖️ Code of Conduct

### Our Standards
- Be welcoming and inclusive
- Respect different viewpoints and experiences
- Accept constructive criticism gracefully
- Focus on what is best for the community
- Show empathy towards other community members

### Enforcement
Instances of abusive, harassing, or otherwise unacceptable behavior may be reported to the project maintainers.

## 📞 Getting Help

If you need help with contributing:
1. Check the documentation
2. Search existing issues
3. Create a new issue with the "question" label
4. Contact the maintainers

Thank you for contributing to EDC Real Estate Management System!
