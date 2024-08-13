.DEFAULT_GOAL := install

install:
	git clean -ffdX
#	./pre.sh
	boilr template save --force dotnet-tool dotnet-tool
	boilr template save --force make make
	boilr template save --force unity unity

validate:
	git clean -ffdX
	boilr template validate dotnet-tool
	boilr template validate make
	boilr template validate unity

clean:
	git clean -ffdX
