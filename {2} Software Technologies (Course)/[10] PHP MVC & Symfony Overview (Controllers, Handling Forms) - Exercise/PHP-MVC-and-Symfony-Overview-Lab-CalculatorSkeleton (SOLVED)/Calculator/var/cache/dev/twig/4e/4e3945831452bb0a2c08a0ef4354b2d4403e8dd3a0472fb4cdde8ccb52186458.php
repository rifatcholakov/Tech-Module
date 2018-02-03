<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_d81ee698e0b376c46d350c04f2fe55c0c9bf096dbfaeab7e781bb4e56fc70da9 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_b04e3eb061ef93f7bcfd7602ef900923de0bf41c095c9bcfe3643e7cb6e701ad = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b04e3eb061ef93f7bcfd7602ef900923de0bf41c095c9bcfe3643e7cb6e701ad->enter($__internal_b04e3eb061ef93f7bcfd7602ef900923de0bf41c095c9bcfe3643e7cb6e701ad_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_b04e3eb061ef93f7bcfd7602ef900923de0bf41c095c9bcfe3643e7cb6e701ad->leave($__internal_b04e3eb061ef93f7bcfd7602ef900923de0bf41c095c9bcfe3643e7cb6e701ad_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_9bff8fafb4efdcf2d05efb6017038b4916c75e1849ffa5681106e2fe1ed92d98 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9bff8fafb4efdcf2d05efb6017038b4916c75e1849ffa5681106e2fe1ed92d98->enter($__internal_9bff8fafb4efdcf2d05efb6017038b4916c75e1849ffa5681106e2fe1ed92d98_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_9bff8fafb4efdcf2d05efb6017038b4916c75e1849ffa5681106e2fe1ed92d98->leave($__internal_9bff8fafb4efdcf2d05efb6017038b4916c75e1849ffa5681106e2fe1ed92d98_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_83e5a83ba387c5847896c9b6406245a57a883f54bb8ed6663f53e1ffcebf51f0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_83e5a83ba387c5847896c9b6406245a57a883f54bb8ed6663f53e1ffcebf51f0->enter($__internal_83e5a83ba387c5847896c9b6406245a57a883f54bb8ed6663f53e1ffcebf51f0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_83e5a83ba387c5847896c9b6406245a57a883f54bb8ed6663f53e1ffcebf51f0->leave($__internal_83e5a83ba387c5847896c9b6406245a57a883f54bb8ed6663f53e1ffcebf51f0_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_f4a77bbcc1da86a7783a7321d5dbc40390be499c851cedba997dda4adcd057f8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f4a77bbcc1da86a7783a7321d5dbc40390be499c851cedba997dda4adcd057f8->enter($__internal_f4a77bbcc1da86a7783a7321d5dbc40390be499c851cedba997dda4adcd057f8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_f4a77bbcc1da86a7783a7321d5dbc40390be499c851cedba997dda4adcd057f8->leave($__internal_f4a77bbcc1da86a7783a7321d5dbc40390be499c851cedba997dda4adcd057f8_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
