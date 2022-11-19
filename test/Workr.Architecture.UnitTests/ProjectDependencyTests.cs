using FluentAssertions;
using NetArchTest.Rules;

namespace Workr.Architecture.UnitTests;

public class ProjectDependencyTests
{
    private const string RootNamespace = "Workr";
    
    private const string ApiNamespace = $"{RootNamespace}.Api";
    private const string ApplicationNamespace = $"{RootNamespace}.Application";
    private const string DomainNamespace = $"{RootNamespace}.Domain";
    private const string InfrastructureNamespace = $"{RootNamespace}.Infrastructure";
    private const string WebNamespace = $"{RootNamespace}.Web";
    
    [Fact(DisplayName = "[ARCH-01] - Domain project should not depend on Application, Infrastructure, Api and Web")]
    public void Domain_Should_NotDependOnOtherProjects()
    {
        var domainAssembly = typeof(Domain.AssemblyReference).Assembly;

        var otherProjectNamespaces = new[]
        {
            ApplicationNamespace,
            InfrastructureNamespace,
            ApiNamespace,
            WebNamespace
        };

        var result = Types
            .InAssembly(domainAssembly)
            .ShouldNot()
            .HaveDependencyOnAll(otherProjectNamespaces)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact(DisplayName = "[ARCH-02] - Application project should not depend on Infrastructure, Api and Web")]
    public void Application_Should_NotDependOnOtherProjects()
    {
        var applicationAssembly = typeof(Application.AssemblyReference).Assembly;
        
        var otherProjectNamespaces = new[]
        {
            InfrastructureNamespace,
            ApiNamespace,
            WebNamespace
        };

        var result = Types
            .InAssembly(applicationAssembly)
            .ShouldNot()
            .HaveDependencyOnAll(otherProjectNamespaces)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact(DisplayName = "[ARCH-03] - Infrastructure project should not depend on Api and Web")]
    public void Infrastructure_ShouldNot_HaveDependencyOnOtherProjects()
    {
        var infrastructureAssembly = typeof(Infrastructure.AssemblyReference).Assembly;
        
        var otherProjectNamespaces = new[]
        {
            ApiNamespace,
            WebNamespace
        };

        var result = Types
            .InAssembly(infrastructureAssembly)
            .ShouldNot()
            .HaveDependencyOnAll(otherProjectNamespaces)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact(DisplayName = "[ARCH-04] - Api project should not depend on Infrastructure and Web")]
    public void Api_ShouldNot_DependOnOtherProjects()
    {
        var apiAssembly = typeof(Api.AssemblyReference).Assembly;
        
        var otherProjectNamespaces = new[]
        {
            InfrastructureNamespace,
            WebNamespace
        };

        var result = Types
            .InAssembly(apiAssembly)
            .ShouldNot()
            .HaveDependencyOnAll(otherProjectNamespaces)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}