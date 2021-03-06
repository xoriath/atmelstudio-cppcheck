﻿namespace atmelstudio_cppcheck.test
{
    public class CppCheckProgressOutput
    {
        public string Output = @"Checking Device_Startup\startup_samd10.c...
Checking Device_Startup\system_samd10.c...
Checking atmel_start.c...
1/21 files checked 3% done
Checking hal\hpl\core\hpl_core_m0plus_base.c...
Checking hal\hpl\core\hpl_init.c...
2/21 files checked 7% done
Checking hal\hpl\gclk\hpl_gclk1_v210_base.c...
3/21 files checked 9% done
Checking hal\hpl\pm\hpl_pm1_v211a.c...
Checking Device_Startup\startup_samd10.c: ID_DAC...
Checking hal\hpl\gclk\hpl_gclk1_v210_base.c: CONF_GCLK_GENERATOR_0_CONFIG=1...
Checking hal\hpl\core\hpl_core_m0plus_base.c: _UNIT_TEST_...
Checking hal\hpl\pm\hpl_pm1_v211a.c: _UNIT_TEST_...
Checking hal\hpl\gclk\hpl_gclk1_v210_base.c: CONF_GCLK_GENERATOR_1_CONFIG=1...
4/21 files checked 14% done
Checking hal\hpl\port\hpl_port_v100.c...
Checking Device_Startup\startup_samd10.c: ID_SERCOM2...
Checking hal\hpl\gclk\hpl_gclk1_v210_base.c: CONF_GCLK_GENERATOR_2_CONFIG=1...
5/21 files checked 21% done
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c...
Checking hal\hpl\gclk\hpl_gclk1_v210_base.c: CONF_GCLK_GENERATOR_3_CONFIG=1...
Checking hal\hpl\gclk\hpl_gclk1_v210_base.c: CONF_GCLK_GENERATOR_4_CONFIG=1...
Checking Device_Startup\startup_samd10.c: ID_USB...
Checking hal\hpl\gclk\hpl_gclk1_v210_base.c: CONF_GCLK_GENERATOR_5_CONFIG=1...
Checking hal\hpl\gclk\hpl_gclk1_v210_base.c: CONF_GCLK_GENERATOR_6_CONFIG=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_DFLL_CONFIG=1...
6/21 files checked 24% done
Checking hal\hpl\systick\hpl_systick_ARMv6_base.c...
Checking hal\hpl\gclk\hpl_gclk1_v210_base.c: CONF_GCLK_GENERATOR_7_CONFIG=1...
7/21 files checked 36% done
Checking hal\src\hal_atomic.c...
8/21 files checked 46% done
Checking hal\src\hal_delay.c...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_DFLL_CONFIG=1;CONF_DFLL_ENABLE=1...
Checking hal\hpl\systick\hpl_systick_ARMv6_base.c: _UNIT_TEST_...
9/21 files checked 49% done
Checking hal\src\hal_gpio.c...
10/21 files checked 52% done
11/21 files checked 56% done
Checking hal\src\hal_init.c...
Checking hal\src\hal_io.c...
12/21 files checked 61% done
Checking led_flasher_main.c...
13/21 files checked 64% done
Checking recursion.c...
14/21 files checked 64% done
Checking utils\src\utils_assert.c...
15/21 files checked 67% done
Checking utils\src\utils_event.c...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_DFLL_CONFIG=1;CONF_DFLL_ONDEMAND=1...
16/21 files checked 68% done
Checking utils\src\utils_list.c...
17/21 files checked 71% done
Checking utils\src\utils_syscalls.c...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_DPLL_CONFIG=1...
18/21 files checked 76% done
19/21 files checked 82% done
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_DPLL_CONFIG=1;CONF_DPLL_ENABLE=1...
20/21 files checked 88% done
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_DPLL_CONFIG=1;CONF_DPLL_ONDEMAND=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_OSC32K_CONFIG=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_OSC32K_CONFIG=1;CONF_OSC32K_ENABLE=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_OSC32K_CONFIG=1;CONF_OSC32K_ONDEMAND=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_OSC32K_CONFIG=1;CONF_OSC32K_OVERWRITE_CALIBRATION=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_OSC8M_CONFIG=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_OSC8M_CONFIG=1;CONF_OSC8M_ENABLE=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_OSC8M_CONFIG=1;CONF_OSC8M_ONDEMAND=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_OSC8M_CONFIG=1;CONF_OSC8M_OVERWRITE_CALIBRATION=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_OSCULP32K_CONFIG=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_OSCULP32K_CONFIG=1;OSC32K_OVERWRITE_CALIBRATION=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_XOSC32K_CONFIG=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_XOSC32K_CONFIG=1;CONF_XOSC32K_ENABLE=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_XOSC32K_CONFIG=1;CONF_XOSC32K_ONDEMAND=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_XOSC_CONFIG=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_XOSC_CONFIG=1;CONF_XOSC_ENABLE=1...
Checking hal\hpl\sysctrl\hpl_sysctrl_v202.c: CONF_XOSC_CONFIG=1;CONF_XOSC_ONDEMAND=1...
21/21 files checked 100% done
";
    }
}
