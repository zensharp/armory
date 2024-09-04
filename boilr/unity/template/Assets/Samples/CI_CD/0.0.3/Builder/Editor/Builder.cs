using BearEngine.CI.Editor;

public static class Builder
{

	public static void Build()
	{
		BearEngine.CI.Builder.OnPreBuild += BuildProcessor.RebuildPlayerContent;
		BearEngine.CI.Builder.Build();
	}
}
