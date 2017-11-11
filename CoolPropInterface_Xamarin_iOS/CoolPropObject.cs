using System;
using CoolPropInterface.source;

namespace CoolPropInterface_Xamarin
{
	public class CoolPropObject : ICoolProp
	{
		public CoolPropObject()
		{
		}

		bool ICoolProp.add_fluids_as_JSON(string backend, string fluidstring)
		{
			return CoolProp.add_fluids_as_JSON(backend, fluidstring);
		}

		double ICoolProp.cair_sat(double T)
		{
			return CoolProp.cair_sat(T);
		}

		string ICoolProp.config_key_description(string key)
		{
			return CoolProp.config_key_description(key);
		}

		string ICoolProp.config_key_description(configuration_keys keys)
		{
			return "";
		}

		string ICoolProp.config_key_to_string(configuration_keys keys)
		{
			return CoolProp.config_key_to_string(keys);
		}

		string ICoolProp.get_config_as_json_string()
		{
			return CoolProp.get_config_as_json_string();
		}

		bool ICoolProp.get_config_bool(configuration_keys key)
		{
			return CoolProp.get_config_bool(key);
		}

		double ICoolProp.get_config_double(configuration_keys key)
		{
			return CoolProp.get_config_double(key);
		}

		string ICoolProp.get_config_string(configuration_keys key)
		{
			return CoolProp.get_config_string(key);
		}

		string ICoolProp.get_csv_parameter_list()
		{
			return CoolProp.get_csv_parameter_list();
		}

		int ICoolProp.get_debug_level()
		{
			return CoolProp.get_debug_level();
		}

		string ICoolProp.get_fluid_param_string(string FluidName, string ParamName)
		{
			return CoolProp.get_fluid_param_string(FluidName, ParamName);
		}

		string ICoolProp.get_global_param_string(string ParamName)
		{
			return CoolProp.get_global_param_string(ParamName);
		}

		input_pairs ICoolProp.get_input_pair_index(string input_pair_name)
		{
			return CoolProp.get_input_pair_index(input_pair_name);
		}

		string ICoolProp.get_input_pair_long_desc(input_pairs pair)
		{
			return CoolProp.get_input_pair_long_desc(pair);
		}

		string ICoolProp.get_input_pair_short_desc(input_pairs pair)
		{
			return CoolProp.get_input_pair_short_desc(pair);
		}

		string ICoolProp.get_mixture_binary_pair_data(string CAS1, string CAS2, string param)
		{
			return CoolProp.get_mixture_binary_pair_data(CAS1, CAS2, param);
		}

		parameters ICoolProp.get_parameter_index(string param_name)
		{
			return CoolProp.get_parameter_index(param_name);
		}

		string ICoolProp.get_parameter_information(int key, string info)
		{
			return CoolProp.get_parameter_information(key, info);
		}

		phases ICoolProp.get_phase_index(string param_name)
		{
			return CoolProp.get_phase_index(param_name);
		}

		void ICoolProp.HAHelp()
		{
			CoolProp.HAHelp();
		}

		double ICoolProp.HAProps(string OutputName, string Input1Name, double Input1, string Input2Name, double Input2, string Input3Name, double Input3)
		{
			return CoolProp.HAProps(OutputName, Input1Name, Input1, Input2Name, Input2, Input3Name, Input3);
		}

		double ICoolProp.HAPropsSI(string OutputName, string Input1Name, double Input1, string Input2Name, double Input2, string Input3Name, double Input3)
		{
			return CoolProp.HAPropsSI(OutputName, Input1Name, Input1, Input2Name, Input2, Input3Name, Input3);
		}

		double ICoolProp.HAProps_Aux(string OutputName, double T, double p, double W, string units)
		{
			return CoolProp.HAProps_Aux(OutputName, T, p, W, units);
		}

		double ICoolProp.IceProps(string Name, double T, double p)
		{
			return CoolProp.IceProps(Name, T, p);
		}

		bool ICoolProp.is_trivial_parameter(int key)
		{
			return CoolProp.is_trivial_parameter(key);
		}

		bool ICoolProp.is_valid_fluid_string(string fluidstring)
		{
			return CoolProp.is_valid_fluid_string(fluidstring);
		}

		string ICoolProp.PhaseSI(string Name1, double Prop1, string Name2, double Prop2, string FluidName)
		{
			return CoolProp.PhaseSI(Name1, Prop1, Name2, Prop2, FluidName);
		}

		double ICoolProp.Props1SI(string FluidName, string Output)
		{
			return CoolProp.Props1SI(FluidName, Output);
		}

		double ICoolProp.PropsSI(string Output, string Name1, double Prop1, string Name2, double Prop2, string FluidName)
		{
			return CoolProp.PropsSI(Output, Name1, Prop1, Name2, Prop2, FluidName);
		}

		int ICoolProp.returnHumAirCode(string Code)
		{
			return 0;
		}

		double ICoolProp.saturation_ancillary(string fluid_name, string output, int Q, string input, double value)
		{
			return CoolProp.saturation_ancillary(fluid_name, output, Q, input, value);
		}

		void ICoolProp.set_config_as_json_string(string s)
		{
			CoolProp.set_config_as_json_string(s);
		}

		void ICoolProp.set_config_bool(configuration_keys key, bool val)
		{
			CoolProp.set_config_bool(key, val);
		}

		void ICoolProp.set_config_double(configuration_keys key, double val)
		{
			CoolProp.set_config_double(key, val);
		}

		void ICoolProp.set_config_string(configuration_keys key, string val)
		{
			CoolProp.set_config_string(key, val);
		}

		void ICoolProp.set_debug_level(int level)
		{
			CoolProp.set_debug_level(level);
		}

		void ICoolProp.set_error_string(string error)
		{
			CoolProp.set_error_string(error);
		}

		void ICoolProp.set_mixture_binary_pair_data(string CAS1, string CAS2, string param, double val)
		{
			CoolProp.set_mixture_binary_pair_data(CAS1, CAS2, param, val);
		}

		void ICoolProp.set_reference_stateD(string FluidName, double T, double rhomolar, double h0, double s0)
		{
			CoolProp.set_reference_stateD(FluidName, T, rhomolar, h0, s0);
		}

		void ICoolProp.set_reference_stateS(string FluidName, string reference_state)
		{
			CoolProp.set_reference_stateS(FluidName, reference_state);
		}

		void ICoolProp.set_warning_string(string warning)
		{
			CoolProp.set_warning_string(warning);
		}

		void ICoolProp.UseIdealGasEnthalpyCorrelations(int flag)
		{
			CoolProp.UseIdealGasEnthalpyCorrelations(flag);
		}

		void ICoolProp.UseIsothermCompressCorrelation(int flag)
		{
			CoolProp.UseIsothermCompressCorrelation(flag);
		}

		void ICoolProp.UseVirialCorrelations(int flag)
		{
			CoolProp.UseVirialCorrelations(flag);
		}
	}
}
