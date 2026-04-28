using System.CommandLine;
using System.CommandLine.Invocation;
using dotnet_repl;

public class SpectreHelpAction : SynchronousCommandLineAction
{
    public override int Invoke(ParseResult parseResult)
    {
        var output = parseResult.InvocationConfiguration.Output;

        new SpectreHelpBuilder().ShowHelp(parseResult.CommandResult.Command, output);

        return 0;
    }
}