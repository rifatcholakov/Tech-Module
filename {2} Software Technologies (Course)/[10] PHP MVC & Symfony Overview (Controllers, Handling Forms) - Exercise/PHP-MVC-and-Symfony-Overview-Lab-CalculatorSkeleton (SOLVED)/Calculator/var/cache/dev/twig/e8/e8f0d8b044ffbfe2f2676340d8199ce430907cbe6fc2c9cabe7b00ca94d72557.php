<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_24b8308b7d2d31da2121362d26e0f7d87f200098338c20ca92ed57c64395fcac extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_ff06cfa645fae5785c3433522471bb93fe3b9490730221167d2bca22ad84d1db = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ff06cfa645fae5785c3433522471bb93fe3b9490730221167d2bca22ad84d1db->enter($__internal_ff06cfa645fae5785c3433522471bb93fe3b9490730221167d2bca22ad84d1db_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_ff06cfa645fae5785c3433522471bb93fe3b9490730221167d2bca22ad84d1db->leave($__internal_ff06cfa645fae5785c3433522471bb93fe3b9490730221167d2bca22ad84d1db_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_352858e8c7d0b45576a10da21ad23afaa409144dc722cf3af1a71f7583ba230a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_352858e8c7d0b45576a10da21ad23afaa409144dc722cf3af1a71f7583ba230a->enter($__internal_352858e8c7d0b45576a10da21ad23afaa409144dc722cf3af1a71f7583ba230a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_352858e8c7d0b45576a10da21ad23afaa409144dc722cf3af1a71f7583ba230a->leave($__internal_352858e8c7d0b45576a10da21ad23afaa409144dc722cf3af1a71f7583ba230a_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_eb195cb1865c71a6643276dacfae6eee40846d0f781d4c2f78e6152a9e766156 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_eb195cb1865c71a6643276dacfae6eee40846d0f781d4c2f78e6152a9e766156->enter($__internal_eb195cb1865c71a6643276dacfae6eee40846d0f781d4c2f78e6152a9e766156_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_eb195cb1865c71a6643276dacfae6eee40846d0f781d4c2f78e6152a9e766156->leave($__internal_eb195cb1865c71a6643276dacfae6eee40846d0f781d4c2f78e6152a9e766156_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_46db89084f9ec50518589b2fcddc80b9874de2b460484afad028044afb01ca76 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_46db89084f9ec50518589b2fcddc80b9874de2b460484afad028044afb01ca76->enter($__internal_46db89084f9ec50518589b2fcddc80b9874de2b460484afad028044afb01ca76_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_46db89084f9ec50518589b2fcddc80b9874de2b460484afad028044afb01ca76->leave($__internal_46db89084f9ec50518589b2fcddc80b9874de2b460484afad028044afb01ca76_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
