<?php

/* base.html.twig */
class __TwigTemplate_26ecc123bf965624589b4425298a5e12186d8bacd81de704cb55a03e6177b7ed extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_fe343b4de43a186b2ee91fbfe48c1cf7f9e2c993554781194caff2d93c873ff2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fe343b4de43a186b2ee91fbfe48c1cf7f9e2c993554781194caff2d93c873ff2->enter($__internal_fe343b4de43a186b2ee91fbfe48c1cf7f9e2c993554781194caff2d93c873ff2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_fe343b4de43a186b2ee91fbfe48c1cf7f9e2c993554781194caff2d93c873ff2->leave($__internal_fe343b4de43a186b2ee91fbfe48c1cf7f9e2c993554781194caff2d93c873ff2_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_34d7a437aeecc8efd7f00ec8d049a2dce2e71fd258e977eb6de0b11d4e82b2de = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_34d7a437aeecc8efd7f00ec8d049a2dce2e71fd258e977eb6de0b11d4e82b2de->enter($__internal_34d7a437aeecc8efd7f00ec8d049a2dce2e71fd258e977eb6de0b11d4e82b2de_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_34d7a437aeecc8efd7f00ec8d049a2dce2e71fd258e977eb6de0b11d4e82b2de->leave($__internal_34d7a437aeecc8efd7f00ec8d049a2dce2e71fd258e977eb6de0b11d4e82b2de_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_508e0476569db37481029d5d8e21eb8f346bd15bdb26e54667f9472d132f5339 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_508e0476569db37481029d5d8e21eb8f346bd15bdb26e54667f9472d132f5339->enter($__internal_508e0476569db37481029d5d8e21eb8f346bd15bdb26e54667f9472d132f5339_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_508e0476569db37481029d5d8e21eb8f346bd15bdb26e54667f9472d132f5339->leave($__internal_508e0476569db37481029d5d8e21eb8f346bd15bdb26e54667f9472d132f5339_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_50c0730c2eca8fc005eb5f172f9a7f2d9d93c5b9d3fcabed9128913961f8641b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_50c0730c2eca8fc005eb5f172f9a7f2d9d93c5b9d3fcabed9128913961f8641b->enter($__internal_50c0730c2eca8fc005eb5f172f9a7f2d9d93c5b9d3fcabed9128913961f8641b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_50c0730c2eca8fc005eb5f172f9a7f2d9d93c5b9d3fcabed9128913961f8641b->leave($__internal_50c0730c2eca8fc005eb5f172f9a7f2d9d93c5b9d3fcabed9128913961f8641b_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_da3081bfb7fc3616ba5e00fe2133cb7c8daeda03bebe569cc9eacc7abd4dd522 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_da3081bfb7fc3616ba5e00fe2133cb7c8daeda03bebe569cc9eacc7abd4dd522->enter($__internal_da3081bfb7fc3616ba5e00fe2133cb7c8daeda03bebe569cc9eacc7abd4dd522_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_da3081bfb7fc3616ba5e00fe2133cb7c8daeda03bebe569cc9eacc7abd4dd522->leave($__internal_da3081bfb7fc3616ba5e00fe2133cb7c8daeda03bebe569cc9eacc7abd4dd522_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_29d72eb45b287b76cf2973e4f97e63339ddbcd6bb60198dab1fab1bd9a22eeac = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_29d72eb45b287b76cf2973e4f97e63339ddbcd6bb60198dab1fab1bd9a22eeac->enter($__internal_29d72eb45b287b76cf2973e4f97e63339ddbcd6bb60198dab1fab1bd9a22eeac_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_29d72eb45b287b76cf2973e4f97e63339ddbcd6bb60198dab1fab1bd9a22eeac->leave($__internal_29d72eb45b287b76cf2973e4f97e63339ddbcd6bb60198dab1fab1bd9a22eeac_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_a5c9b65798ed1063ddb7ab95bddfb0848ee45ef1838be8994b0bdf4baa1dfd01 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a5c9b65798ed1063ddb7ab95bddfb0848ee45ef1838be8994b0bdf4baa1dfd01->enter($__internal_a5c9b65798ed1063ddb7ab95bddfb0848ee45ef1838be8994b0bdf4baa1dfd01_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_a5c9b65798ed1063ddb7ab95bddfb0848ee45ef1838be8994b0bdf4baa1dfd01->leave($__internal_a5c9b65798ed1063ddb7ab95bddfb0848ee45ef1838be8994b0bdf4baa1dfd01_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_0544caee63f6d601986a4a3f454d4b0d40a9cdedf6514e2b6ae26d301b5d1b8b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0544caee63f6d601986a4a3f454d4b0d40a9cdedf6514e2b6ae26d301b5d1b8b->enter($__internal_0544caee63f6d601986a4a3f454d4b0d40a9cdedf6514e2b6ae26d301b5d1b8b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_0544caee63f6d601986a4a3f454d4b0d40a9cdedf6514e2b6ae26d301b5d1b8b->leave($__internal_0544caee63f6d601986a4a3f454d4b0d40a9cdedf6514e2b6ae26d301b5d1b8b_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
