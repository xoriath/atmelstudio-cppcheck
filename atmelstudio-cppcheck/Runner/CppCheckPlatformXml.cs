
namespace atmelstudio_cppcheck.Runner
{
// TODO: have these as xml assets
    class CppCheckPlatformXml
    {
        public string Avr8PlatformXml = @"<?xml version='1'?>
<platform>
	<char_bit>8</char_bit>
	<default-sign>signed</default-sign>
	<sizeof>
		<short>2</short>
		<int>2</int>
		<long>4</long>
		<long-long>8</long-long>

		<float>4</float>
		<double>4</double>
		<long-double>4</long-double>
		<pointer>2</pointer>
		<size_t>2</size_t>
		<wchar_t>2</wchar_t>
	</sizeof>
</platform>";

        public string Avr32PlatformXml = @"<?xml version='1'?>
<platform>
	<char_bit>8</char_bit>
	<default-sign>signed</default-sign>
	<sizeof>
		<short>2</short>
		<int>4</int>
		<long>4</long>
		<long-long>8</long-long>

		<float>4</float>
		<double>8</double>
		<long-double>12</long-double>
		<pointer>4</pointer>
		<size_t>4</size_t>
		<wchar_t>2</wchar_t>
	</sizeof>
</platform>";

        public string CortexMPlatformXml = @"<?xml version='1'?>
<platform>
	<char_bit>8</char_bit>
	<default-sign>signed</default-sign>
	<sizeof>
		<short>2</short>
		<int>4</int>
		<long>4</long>
		<long-long>8</long-long>

		<float>4</float>
		<double>8</double>
		<long-double>12</long-double>
		<pointer>4</pointer>
		<size_t>4</size_t>
		<wchar_t>2</wchar_t>
	</sizeof>
</platform>";
    }
}
