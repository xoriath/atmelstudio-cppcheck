using System.Xml.Linq;

namespace atmelstudio_cppcheck.test
{
    class CppCheckXmlOutput
    {
        public static XElement ResultsVersion2 = XElement.Parse(@"<?xml version='1.0' encoding='UTF-8'?>
<results version='2'>
    <cppcheck version='1.73'/>
    <errors>
        <error id='unreadVariable' severity='style' msg='Variable &amp;#039;a&amp;#039; is assigned a value that is never used.' verbose='Variable &amp;#039;a&amp;#039; is assigned a value that is never used.'>
            <location file='led_flasher_main.c' line='12'/>
        </error>
        <error id='unreadVariable' severity='style' msg='Variable &amp;#039;hw&amp;#039; is assigned a value that is never used.' verbose='Variable &amp;#039;hw&amp;#039; is assigned a value that is never used.'>
            <location file0='hal/hpl/gclk/hpl_gclk1_v210_base.c' file='hal\hpl\gclk\hpl_gclk1_v210_base.c' line='55'/>
        </error>
        <error id='unassignedVariable' severity='style' msg='Variable &amp;#039;calib&amp;#039; is not assigned a value.' verbose='Variable &amp;#039;calib&amp;#039; is not assigned a value.'>
            <location file0='hal/hpl/sysctrl/hpl_sysctrl_v202.c' file='hal\hpl\sysctrl\hpl_sysctrl_v202.c' line='60'/>
        </error>
    </errors>
</results>");


        public static XElement ResultsVersion1 = XElement.Parse(@"<?xml version='1.0' encoding='UTF-8'?>
<results>
    <error file='led_flasher_main.c' line='12' id='unreadVariable' severity='style' msg='Variable &amp;#039;a&amp;#039; is assigned a value that is never used.'/>
    <error file='hal\hpl\gclk\hpl_gclk1_v210_base.c' line='55' id='unreadVariable' severity='style' msg='Variable &amp;#039;hw&amp;#039; is assigned a value that is never used.'/>
    <error file='hal\hpl\sysctrl\hpl_sysctrl_v202.c' line='60' id='unassignedVariable' severity='style' msg='Variable &amp;#039;calib&amp;#039; is not assigned a value.'/>
</results>");

        public static XElement ResultsInvalidVersion = XElement.Parse(@"<?xml version='1.0' encoding='UTF-8'?>
<results version='239'/>");
    }
}
