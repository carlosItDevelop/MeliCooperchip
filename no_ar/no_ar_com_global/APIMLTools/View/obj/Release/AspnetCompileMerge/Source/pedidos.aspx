﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pedidos.aspx.cs" Inherits="view.pedidos" %>



<!doctype html>
<!--[if lt IE 8]><html class="no-js lt-ie8"> <![endif]-->
<html class="no-js" lang="pt-BR">


    <head>

        <% Server.Execute("head.aspx"); %>



    </head>
    <body>


        <% Server.Execute("page-mynav.aspx"); %>
        <% //Server.Execute("page-nav.aspx"); %>

        <% Server.Execute("menu_principal.aspx"); %>

        <% Server.Execute("sidebar-direito.aspx"); %>

        <!-- .page-content-inner -->  
        <!-- INÍCIO DO CÓDIGO PERSONALIZADO/-->





                        <div id="page-header" class="clearfix">
                            <div class="page-header">
                                <h2>Pedidos</h2>
                                <span class="txt">Gerenciamento de Pedidos</span>
                            </div>


                            <% Server.Execute("boxes-cas.aspx"); %>


                        </div>



                        <!-- Start .row -->
                        <div class="row">
                        </div>
                        <!-- End .row -->



                              <!-- col-md-6 start here -->
                                <div class="panel panel-default toggle panelMove panelClose panelRefresh">
                                    <!-- Start .panel -->
                                    <div class="panel-heading">
                                        <h4 class="panel-title">Orders Management</h4>
                                    </div>
                                    <div class="panel-body">

                                        
                                        <h2>Mercado Livre - Pedidos</h2>


                                            <!-- Tabela com os pedidos -->
                                            <!-- col-lg-12 end here -->
                                            <div class="col-lg-12">
                                                <!-- col-lg-12 start here -->
                                                <div class="panel panel-default toggle panelMove panelClose panelRefresh">
                                                    <!-- Start .panel -->
                                                    <div class="panel-heading">
                                                        <h4 class="panel-title">Pedidos</h4>
                                                    </div>
                                                    <div class="panel-body">
                                                        <table id="tabletools" class="table table-striped table-bordered" cellspacing="0" width="100%">
                                                            <thead>
                                                                <tr>
                                                                    <th>Name</th>
                                                                    <th>Position</th>
                                                                    <th>Office</th>
                                                                    <th>Age</th>
                                                                    <th>Start date</th>
                                                                    <th>Salary</th>
                                                                </tr>
                                                            </thead>
                                                            <tfoot>
                                                                <tr>
                                                                    <th>Name</th>
                                                                    <th>Position</th>
                                                                    <th>Office</th>
                                                                    <th>Age</th>
                                                                    <th>Start date</th>
                                                                    <th>Salary</th>
                                                                </tr>
                                                            </tfoot>
                                                            <tbody>
                                                                <tr>
                                                                    <td>Tiger Nixon</td>
                                                                    <td>System Architect</td>
                                                                    <td>Edinburgh</td>
                                                                    <td>61</td>
                                                                    <td>2011/04/25</td>
                                                                    <td>$320,800</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Garrett Winters</td>
                                                                    <td>Accountant</td>
                                                                    <td>Tokyo</td>
                                                                    <td>63</td>
                                                                    <td>2011/07/25</td>
                                                                    <td>$170,750</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Ashton Cox</td>
                                                                    <td>Junior Technical Author</td>
                                                                    <td>San Francisco</td>
                                                                    <td>66</td>
                                                                    <td>2009/01/12</td>
                                                                    <td>$86,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Cedric Kelly</td>
                                                                    <td>Senior Javascript Developer</td>
                                                                    <td>Edinburgh</td>
                                                                    <td>22</td>
                                                                    <td>2012/03/29</td>
                                                                    <td>$433,060</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Airi Satou</td>
                                                                    <td>Accountant</td>
                                                                    <td>Tokyo</td>
                                                                    <td>33</td>
                                                                    <td>2008/11/28</td>
                                                                    <td>$162,700</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Brielle Williamson</td>
                                                                    <td>Integration Specialist</td>
                                                                    <td>New York</td>
                                                                    <td>61</td>
                                                                    <td>2012/12/02</td>
                                                                    <td>$372,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Herrod Chandler</td>
                                                                    <td>Sales Assistant</td>
                                                                    <td>San Francisco</td>
                                                                    <td>59</td>
                                                                    <td>2012/08/06</td>
                                                                    <td>$137,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Rhona Davidson</td>
                                                                    <td>Integration Specialist</td>
                                                                    <td>Tokyo</td>
                                                                    <td>55</td>
                                                                    <td>2010/10/14</td>
                                                                    <td>$327,900</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Colleen Hurst</td>
                                                                    <td>Javascript Developer</td>
                                                                    <td>San Francisco</td>
                                                                    <td>39</td>
                                                                    <td>2009/09/15</td>
                                                                    <td>$205,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Sonya Frost</td>
                                                                    <td>Software Engineer</td>
                                                                    <td>Edinburgh</td>
                                                                    <td>23</td>
                                                                    <td>2008/12/13</td>
                                                                    <td>$103,600</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Jena Gaines</td>
                                                                    <td>Office Manager</td>
                                                                    <td>London</td>
                                                                    <td>30</td>
                                                                    <td>2008/12/19</td>
                                                                    <td>$90,560</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Quinn Flynn</td>
                                                                    <td>Support Lead</td>
                                                                    <td>Edinburgh</td>
                                                                    <td>22</td>
                                                                    <td>2013/03/03</td>
                                                                    <td>$342,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Charde Marshall</td>
                                                                    <td>Regional Director</td>
                                                                    <td>San Francisco</td>
                                                                    <td>36</td>
                                                                    <td>2008/10/16</td>
                                                                    <td>$470,600</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Haley Kennedy</td>
                                                                    <td>Senior Marketing Designer</td>
                                                                    <td>London</td>
                                                                    <td>43</td>
                                                                    <td>2012/12/18</td>
                                                                    <td>$313,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Tatyana Fitzpatrick</td>
                                                                    <td>Regional Director</td>
                                                                    <td>London</td>
                                                                    <td>19</td>
                                                                    <td>2010/03/17</td>
                                                                    <td>$385,750</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Michael Silva</td>
                                                                    <td>Marketing Designer</td>
                                                                    <td>London</td>
                                                                    <td>66</td>
                                                                    <td>2012/11/27</td>
                                                                    <td>$198,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Paul Byrd</td>
                                                                    <td>Chief Financial Officer (CFO)</td>
                                                                    <td>New York</td>
                                                                    <td>64</td>
                                                                    <td>2010/06/09</td>
                                                                    <td>$725,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Gloria Little</td>
                                                                    <td>Systems Administrator</td>
                                                                    <td>New York</td>
                                                                    <td>59</td>
                                                                    <td>2009/04/10</td>
                                                                    <td>$237,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Bradley Greer</td>
                                                                    <td>Software Engineer</td>
                                                                    <td>London</td>
                                                                    <td>41</td>
                                                                    <td>2012/10/13</td>
                                                                    <td>$132,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Dai Rios</td>
                                                                    <td>Personnel Lead</td>
                                                                    <td>Edinburgh</td>
                                                                    <td>35</td>
                                                                    <td>2012/09/26</td>
                                                                    <td>$217,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Jenette Caldwell</td>
                                                                    <td>Development Lead</td>
                                                                    <td>New York</td>
                                                                    <td>30</td>
                                                                    <td>2011/09/03</td>
                                                                    <td>$345,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Yuri Berry</td>
                                                                    <td>Chief Marketing Officer (CMO)</td>
                                                                    <td>New York</td>
                                                                    <td>40</td>
                                                                    <td>2009/06/25</td>
                                                                    <td>$675,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Caesar Vance</td>
                                                                    <td>Pre-Sales Support</td>
                                                                    <td>New York</td>
                                                                    <td>21</td>
                                                                    <td>2011/12/12</td>
                                                                    <td>$106,450</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Doris Wilder</td>
                                                                    <td>Sales Assistant</td>
                                                                    <td>Sidney</td>
                                                                    <td>23</td>
                                                                    <td>2010/09/20</td>
                                                                    <td>$85,600</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Angelica Ramos</td>
                                                                    <td>Chief Executive Officer (CEO)</td>
                                                                    <td>London</td>
                                                                    <td>47</td>
                                                                    <td>2009/10/09</td>
                                                                    <td>$1,200,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Gavin Joyce</td>
                                                                    <td>Developer</td>
                                                                    <td>Edinburgh</td>
                                                                    <td>42</td>
                                                                    <td>2010/12/22</td>
                                                                    <td>$92,575</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Jennifer Chang</td>
                                                                    <td>Regional Director</td>
                                                                    <td>Singapore</td>
                                                                    <td>28</td>
                                                                    <td>2010/11/14</td>
                                                                    <td>$357,650</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Brenden Wagner</td>
                                                                    <td>Software Engineer</td>
                                                                    <td>San Francisco</td>
                                                                    <td>28</td>
                                                                    <td>2011/06/07</td>
                                                                    <td>$206,850</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Fiona Green</td>
                                                                    <td>Chief Operating Officer (COO)</td>
                                                                    <td>San Francisco</td>
                                                                    <td>48</td>
                                                                    <td>2010/03/11</td>
                                                                    <td>$850,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Shou Itou</td>
                                                                    <td>Regional Marketing</td>
                                                                    <td>Tokyo</td>
                                                                    <td>20</td>
                                                                    <td>2011/08/14</td>
                                                                    <td>$163,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Michelle House</td>
                                                                    <td>Integration Specialist</td>
                                                                    <td>Sidney</td>
                                                                    <td>37</td>
                                                                    <td>2011/06/02</td>
                                                                    <td>$95,400</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Suki Burks</td>
                                                                    <td>Developer</td>
                                                                    <td>London</td>
                                                                    <td>53</td>
                                                                    <td>2009/10/22</td>
                                                                    <td>$114,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Prescott Bartlett</td>
                                                                    <td>Technical Author</td>
                                                                    <td>London</td>
                                                                    <td>27</td>
                                                                    <td>2011/05/07</td>
                                                                    <td>$145,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Gavin Cortez</td>
                                                                    <td>Team Leader</td>
                                                                    <td>San Francisco</td>
                                                                    <td>22</td>
                                                                    <td>2008/10/26</td>
                                                                    <td>$235,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Martena Mccray</td>
                                                                    <td>Post-Sales support</td>
                                                                    <td>Edinburgh</td>
                                                                    <td>46</td>
                                                                    <td>2011/03/09</td>
                                                                    <td>$324,050</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Unity Butler</td>
                                                                    <td>Marketing Designer</td>
                                                                    <td>San Francisco</td>
                                                                    <td>47</td>
                                                                    <td>2009/12/09</td>
                                                                    <td>$85,675</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Howard Hatfield</td>
                                                                    <td>Office Manager</td>
                                                                    <td>San Francisco</td>
                                                                    <td>51</td>
                                                                    <td>2008/12/16</td>
                                                                    <td>$164,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Hope Fuentes</td>
                                                                    <td>Secretary</td>
                                                                    <td>San Francisco</td>
                                                                    <td>41</td>
                                                                    <td>2010/02/12</td>
                                                                    <td>$109,850</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Vivian Harrell</td>
                                                                    <td>Financial Controller</td>
                                                                    <td>San Francisco</td>
                                                                    <td>62</td>
                                                                    <td>2009/02/14</td>
                                                                    <td>$452,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Timothy Mooney</td>
                                                                    <td>Office Manager</td>
                                                                    <td>London</td>
                                                                    <td>37</td>
                                                                    <td>2008/12/11</td>
                                                                    <td>$136,200</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Jackson Bradshaw</td>
                                                                    <td>Director</td>
                                                                    <td>New York</td>
                                                                    <td>65</td>
                                                                    <td>2008/09/26</td>
                                                                    <td>$645,750</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Olivia Liang</td>
                                                                    <td>Support Engineer</td>
                                                                    <td>Singapore</td>
                                                                    <td>64</td>
                                                                    <td>2011/02/03</td>
                                                                    <td>$234,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Bruno Nash</td>
                                                                    <td>Software Engineer</td>
                                                                    <td>London</td>
                                                                    <td>38</td>
                                                                    <td>2011/05/03</td>
                                                                    <td>$163,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Sakura Yamamoto</td>
                                                                    <td>Support Engineer</td>
                                                                    <td>Tokyo</td>
                                                                    <td>37</td>
                                                                    <td>2009/08/19</td>
                                                                    <td>$139,575</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Thor Walton</td>
                                                                    <td>Developer</td>
                                                                    <td>New York</td>
                                                                    <td>61</td>
                                                                    <td>2013/08/11</td>
                                                                    <td>$98,540</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Finn Camacho</td>
                                                                    <td>Support Engineer</td>
                                                                    <td>San Francisco</td>
                                                                    <td>47</td>
                                                                    <td>2009/07/07</td>
                                                                    <td>$87,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Serge Baldwin</td>
                                                                    <td>Data Coordinator</td>
                                                                    <td>Singapore</td>
                                                                    <td>64</td>
                                                                    <td>2012/04/09</td>
                                                                    <td>$138,575</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Zenaida Frank</td>
                                                                    <td>Software Engineer</td>
                                                                    <td>New York</td>
                                                                    <td>63</td>
                                                                    <td>2010/01/04</td>
                                                                    <td>$125,250</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Zorita Serrano</td>
                                                                    <td>Software Engineer</td>
                                                                    <td>San Francisco</td>
                                                                    <td>56</td>
                                                                    <td>2012/06/01</td>
                                                                    <td>$115,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Jennifer Acosta</td>
                                                                    <td>Junior Javascript Developer</td>
                                                                    <td>Edinburgh</td>
                                                                    <td>43</td>
                                                                    <td>2013/02/01</td>
                                                                    <td>$75,650</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Cara Stevens</td>
                                                                    <td>Sales Assistant</td>
                                                                    <td>New York</td>
                                                                    <td>46</td>
                                                                    <td>2011/12/06</td>
                                                                    <td>$145,600</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Hermione Butler</td>
                                                                    <td>Regional Director</td>
                                                                    <td>London</td>
                                                                    <td>47</td>
                                                                    <td>2011/03/21</td>
                                                                    <td>$356,250</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Lael Greer</td>
                                                                    <td>Systems Administrator</td>
                                                                    <td>London</td>
                                                                    <td>21</td>
                                                                    <td>2009/02/27</td>
                                                                    <td>$103,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Jonas Alexander</td>
                                                                    <td>Developer</td>
                                                                    <td>San Francisco</td>
                                                                    <td>30</td>
                                                                    <td>2010/07/14</td>
                                                                    <td>$86,500</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Shad Decker</td>
                                                                    <td>Regional Director</td>
                                                                    <td>Edinburgh</td>
                                                                    <td>51</td>
                                                                    <td>2008/11/13</td>
                                                                    <td>$183,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Michael Bruce</td>
                                                                    <td>Javascript Developer</td>
                                                                    <td>Singapore</td>
                                                                    <td>29</td>
                                                                    <td>2011/06/27</td>
                                                                    <td>$183,000</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Donna Snider</td>
                                                                    <td>Customer Support</td>
                                                                    <td>New York</td>
                                                                    <td>27</td>
                                                                    <td>2011/01/25</td>
                                                                    <td>$112,000</td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </div>
                                                </div>
                                                <!-- End .panel -->
                                            </div>
                                            <!-- col-lg-12 end here -->


                                    </div>
                                </div>
                                <!-- End .panel -->

 

        <!-- FIM DO CÓDIGO PERSONALIZADO/-->
        <!-- / .page-content-inner -->

        <% Server.Execute("nav-inferior.aspx"); %>


        <!-- Javascripts -->
        <!-- Load pace first -->
        <script src="plugins/core/pace/pace.min.js"></script>
        <!-- Important javascript libs(put in all pages) -->
        <script src="http://code.jquery.com/jquery-2.1.1.min.js"></script>
        <script>
            window.jQuery || document.write('<script src="js/libs/jquery-2.1.1.min.js">\x3C/script>')
        </script>
        <script src="http://code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
        <script>
            window.jQuery || document.write('<script src="js/libs/jquery-ui-1.10.4.min.js">\x3C/script>')
        </script>
        <!--[if lt IE 9]>
  <script type="text/javascript" src="js/libs/excanvas.min.js"></script>
  <script type="text/javascript" src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
  <script type="text/javascript" src="js/libs/respond.min.js"></script>
<![endif]-->
        <!-- Bootstrap plugins -->
        <script src="js/bootstrap/bootstrap.js"></script>
        <!-- Core plugins ( not remove ) -->
        <script src="js/libs/modernizr.custom.js"></script>
        <!-- Handle responsive view functions -->
        <script src="js/jRespond.min.js"></script>
        <!-- Custom scroll for sidebars,tables and etc. -->
        <script src="plugins/core/slimscroll/jquery.slimscroll.min.js"></script>
        <script src="plugins/core/slimscroll/jquery.slimscroll.horizontal.min.js"></script>
        <!-- Remove click delay in touch -->
        <script src="plugins/core/fastclick/fastclick.js"></script>
        <!-- Increase jquery animation speed -->
        <script src="plugins/core/velocity/jquery.velocity.min.js"></script>
        <!-- Quick search plugin (fast search for many widgets) -->
        <script src="plugins/core/quicksearch/jquery.quicksearch.js"></script>
        <!-- Bootbox fast bootstrap modals -->
        <script src="plugins/ui/bootbox/bootbox.js"></script>
        <!-- Other plugins ( load only nessesary plugins for every page) -->
        <script src="plugins/charts/sparklines/jquery.sparkline.js"></script>
        <script src="plugins/tables/datatables/jquery.dataTables.js"></script>
        <script src="plugins/tables/datatables/dataTables.tableTools.js"></script>
        <script src="plugins/tables/datatables/dataTables.bootstrap.js"></script>
        <script src="plugins/tables/datatables/dataTables.responsive.js"></script>
        <script src="js/jquery.dynamic.js"></script>
        <script src="js/main.js"></script>
        <script src="js/pages/tables-data.js"></script>
    </body>
</html>