//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CoolProp {
  public static string get_parameter_information(int key, string info) {
    string ret = CoolPropPINVOKE.get_parameter_information(key, info);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static parameters get_parameter_index(string param_name) {
    parameters ret = (parameters)CoolPropPINVOKE.get_parameter_index(param_name);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static phases get_phase_index(string param_name) {
    phases ret = (phases)CoolPropPINVOKE.get_phase_index(param_name);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool is_trivial_parameter(int key) {
    bool ret = CoolPropPINVOKE.is_trivial_parameter(key);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool is_valid_parameter(string name, SWIGTYPE_p_CoolProp__parameters iOutput) {
    bool ret = CoolPropPINVOKE.is_valid_parameter(name, SWIGTYPE_p_CoolProp__parameters.getCPtr(iOutput));
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool is_valid_first_derivative(string name, SWIGTYPE_p_CoolProp__parameters iOf, SWIGTYPE_p_CoolProp__parameters iWrt, SWIGTYPE_p_CoolProp__parameters iConstant) {
    bool ret = CoolPropPINVOKE.is_valid_first_derivative(name, SWIGTYPE_p_CoolProp__parameters.getCPtr(iOf), SWIGTYPE_p_CoolProp__parameters.getCPtr(iWrt), SWIGTYPE_p_CoolProp__parameters.getCPtr(iConstant));
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool is_valid_first_saturation_derivative(string name, SWIGTYPE_p_CoolProp__parameters iOf, SWIGTYPE_p_CoolProp__parameters iWrt) {
    bool ret = CoolPropPINVOKE.is_valid_first_saturation_derivative(name, SWIGTYPE_p_CoolProp__parameters.getCPtr(iOf), SWIGTYPE_p_CoolProp__parameters.getCPtr(iWrt));
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool is_valid_second_derivative(string name, SWIGTYPE_p_CoolProp__parameters iOf1, SWIGTYPE_p_CoolProp__parameters iWrt1, SWIGTYPE_p_CoolProp__parameters iConstant1, SWIGTYPE_p_CoolProp__parameters iWrt2, SWIGTYPE_p_CoolProp__parameters iConstant2) {
    bool ret = CoolPropPINVOKE.is_valid_second_derivative(name, SWIGTYPE_p_CoolProp__parameters.getCPtr(iOf1), SWIGTYPE_p_CoolProp__parameters.getCPtr(iWrt1), SWIGTYPE_p_CoolProp__parameters.getCPtr(iConstant1), SWIGTYPE_p_CoolProp__parameters.getCPtr(iWrt2), SWIGTYPE_p_CoolProp__parameters.getCPtr(iConstant2));
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string get_csv_parameter_list() {
    string ret = CoolPropPINVOKE.get_csv_parameter_list();
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool match_pair(parameters key1, parameters key2, parameters x1, parameters x2, SWIGTYPE_p_bool swap) {
    bool ret = CoolPropPINVOKE.match_pair((int)key1, (int)key2, (int)x1, (int)x2, SWIGTYPE_p_bool.getCPtr(swap));
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static input_pairs get_input_pair_index(string input_pair_name) {
    input_pairs ret = (input_pairs)CoolPropPINVOKE.get_input_pair_index(input_pair_name);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string get_input_pair_short_desc(input_pairs pair) {
    string ret = CoolPropPINVOKE.get_input_pair_short_desc((int)pair);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string get_input_pair_long_desc(input_pairs pair) {
    string ret = CoolPropPINVOKE.get_input_pair_long_desc((int)pair);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void split_input_pair(input_pairs pair, SWIGTYPE_p_CoolProp__parameters p1, SWIGTYPE_p_CoolProp__parameters p2) {
    CoolPropPINVOKE.split_input_pair((int)pair, SWIGTYPE_p_CoolProp__parameters.getCPtr(p1), SWIGTYPE_p_CoolProp__parameters.getCPtr(p2));
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static string get_mixture_binary_pair_data(string CAS1, string CAS2, string param) {
    string ret = CoolPropPINVOKE.get_mixture_binary_pair_data(CAS1, CAS2, param);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void set_mixture_binary_pair_data(string CAS1, string CAS2, string param, double val) {
    CoolPropPINVOKE.set_mixture_binary_pair_data(CAS1, CAS2, param, val);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static double Props1SI(string FluidName, string Output) {
    double ret = CoolPropPINVOKE.Props1SI(FluidName, Output);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double PropsSI(string Output, string Name1, double Prop1, string Name2, double Prop2, string FluidName) {
    double ret = CoolPropPINVOKE.PropsSI(Output, Name1, Prop1, Name2, Prop2, FluidName);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static VectorOfDoubleVector PropsSImulti(StringVector Outputs, string Name1, DoubleVector Prop1, string Name2, DoubleVector Prop2, string backend, StringVector fluids, DoubleVector fractions) {
    VectorOfDoubleVector ret = new VectorOfDoubleVector(CoolPropPINVOKE.PropsSImulti(StringVector.getCPtr(Outputs), Name1, DoubleVector.getCPtr(Prop1), Name2, DoubleVector.getCPtr(Prop2), backend, StringVector.getCPtr(fluids), DoubleVector.getCPtr(fractions)), true);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int get_debug_level() {
    int ret = CoolPropPINVOKE.get_debug_level();
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void set_debug_level(int level) {
    CoolPropPINVOKE.set_debug_level(level);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void set_error_string(string error) {
    CoolPropPINVOKE.set_error_string(error);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void set_warning_string(string warning) {
    CoolPropPINVOKE.set_warning_string(warning);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static double saturation_ancillary(string fluid_name, string output, int Q, string input, double value) {
    double ret = CoolPropPINVOKE.saturation_ancillary(fluid_name, output, Q, input, value);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string get_global_param_string(string ParamName) {
    string ret = CoolPropPINVOKE.get_global_param_string(ParamName);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string get_fluid_param_string(string FluidName, string ParamName) {
    string ret = CoolPropPINVOKE.get_fluid_param_string(FluidName, ParamName);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool is_valid_fluid_string(string fluidstring) {
    bool ret = CoolPropPINVOKE.is_valid_fluid_string(fluidstring);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool add_fluids_as_JSON(string backend, string fluidstring) {
    bool ret = CoolPropPINVOKE.add_fluids_as_JSON(backend, fluidstring);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void set_reference_stateS(string FluidName, string reference_state) {
    CoolPropPINVOKE.set_reference_stateS(FluidName, reference_state);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void set_reference_stateD(string FluidName, double T, double rhomolar, double h0, double s0) {
    CoolPropPINVOKE.set_reference_stateD(FluidName, T, rhomolar, h0, s0);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static string PhaseSI(string Name1, double Prop1, string Name2, double Prop2, string FluidName) {
    string ret = CoolPropPINVOKE.PhaseSI(Name1, Prop1, Name2, Prop2, FluidName);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void extract_backend(string fluid_string, SWIGTYPE_p_std__string backend, SWIGTYPE_p_std__string fluid) {
    CoolPropPINVOKE.extract_backend(fluid_string, SWIGTYPE_p_std__string.getCPtr(backend), SWIGTYPE_p_std__string.getCPtr(fluid));
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static string extract_fractions(string fluid_string, DoubleVector fractions) {
    string ret = CoolPropPINVOKE.extract_fractions(fluid_string, DoubleVector.getCPtr(fractions));
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string config_key_to_string(configuration_keys keys) {
    string ret = CoolPropPINVOKE.config_key_to_string((int)keys);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string config_key_description(configuration_keys keys) {
    string ret = CoolPropPINVOKE.config_key_description__SWIG_0((int)keys);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string config_key_description(string key) {
    string ret = CoolPropPINVOKE.config_key_description__SWIG_1(key);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool get_config_bool(configuration_keys key) {
    bool ret = CoolPropPINVOKE.get_config_bool((int)key);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double get_config_double(configuration_keys key) {
    double ret = CoolPropPINVOKE.get_config_double((int)key);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string get_config_string(configuration_keys key) {
    string ret = CoolPropPINVOKE.get_config_string((int)key);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string get_config_as_json_string() {
    string ret = CoolPropPINVOKE.get_config_as_json_string();
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void set_config_bool(configuration_keys key, bool val) {
    CoolPropPINVOKE.set_config_bool((int)key, val);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void set_config_double(configuration_keys key, double val) {
    CoolPropPINVOKE.set_config_double((int)key, val);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void set_config_string(configuration_keys key, string val) {
    CoolPropPINVOKE.set_config_string((int)key, val);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void set_config_as_json_string(string s) {
    CoolPropPINVOKE.set_config_as_json_string(s);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static double HAPropsSI(string OutputName, string Input1Name, double Input1, string Input2Name, double Input2, string Input3Name, double Input3) {
    double ret = CoolPropPINVOKE.HAPropsSI(OutputName, Input1Name, Input1, Input2Name, Input2, Input3Name, Input3);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double HAProps(string OutputName, string Input1Name, double Input1, string Input2Name, double Input2, string Input3Name, double Input3) {
    double ret = CoolPropPINVOKE.HAProps(OutputName, Input1Name, Input1, Input2Name, Input2, Input3Name, Input3);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double HAProps_Aux(string OutputName, double T, double p, double W, string units) {
    double ret = CoolPropPINVOKE.HAProps_Aux(OutputName, T, p, W, units);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double IceProps(string Name, double T, double p) {
    double ret = CoolPropPINVOKE.IceProps(Name, T, p);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void UseVirialCorrelations(int flag) {
    CoolPropPINVOKE.UseVirialCorrelations(flag);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void UseIsothermCompressCorrelation(int flag) {
    CoolPropPINVOKE.UseIsothermCompressCorrelation(flag);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void UseIdealGasEnthalpyCorrelations(int flag) {
    CoolPropPINVOKE.UseIdealGasEnthalpyCorrelations(flag);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void HAHelp() {
    CoolPropPINVOKE.HAHelp();
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public static int returnHumAirCode(string Code) {
    int ret = CoolPropPINVOKE.returnHumAirCode(Code);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double cair_sat(double T) {
    double ret = CoolPropPINVOKE.cair_sat(T);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
