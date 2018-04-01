--------------inserting product lines
insert into productLine
values('Communication Systems', null, 'Traditional Key Systems|Hybrid IP Systems|IP Systems(Pure IP)|Software Ancillary Applications', 'communicationSystems.png');

insert into productLine
values('Telephony Products', null, 'Consumer Telephone Products|Telephony Peripherals and Accessories|Headsets|Headset Peripherals and Accessories', 'telephonyProducts.png');

insert into productLine
values('Audio/Video Products', null, 'Audio Conferencing Table Top|Audio Conferencing Installed Voice|Video Conferencing|Paging Products', 'avProducts.png');

insert into productLine
values('Security Products', null, 'Security Cameras|Security Recording Devices|Security Accessories and Peripherals|Software', 'securityProducts.png');

insert into productLine
values('Data Networking', null, 'Servers and Storage|Switches and Routers|Wireless Data Products|Test Equipment', 'dataNetworking.png');

insert into productLine
values('Peripherals and Accessories', null, 'Emergency Telephones|Cabinets and Enclosures|Connectivity and Wire/Fiber|Tools', 'accessories.png');

--------------inserting products

--comm systems
insert into products
values('Digium D60', 'Entry-Level HD Phone', 'Line Keys - 2-line keys and Ethernet Connectivity - 2 x 10/100 Mbps network ports|Display Type - 4.3 inch, 480 x 272 pixel full-color LCD display|PoE - 802.3at/af Power over Ethernete and Headset Support - Electronic', '138.98', 1, 'digiumD60.png');

insert into products
values('Aastra Meridian 6320', 'Digital Phone', 'The next generation in the development of digital Centrex telephones|Sleek new styling|Ideally suited for both medium/large enterprises', '79.99', 1, 'aastraMeridian6320.png');

insert into products
values('Avaya IP Office Phone System', '8 Phone System: Esseential Edition', '2 x Avaya IPO IP500 V2 Combination Card|8 x Avaya 16-Button Digital Phone - Black|1 x Avaya IP Office Power Lead', '3199.69', 1, 'avayaIPOfficePhoneSystem.png');

insert into products
values('Grandstream DP720', 'Expansion Handset', 'Cordless 10-line phone with speakerphone|A VoIP phone that allows users to mobilize their network|Includes support for SIP accounts','55.00', 1, 'grandstreamDP720.png');
--telephony
insert into products
values('Plantronics M 214C', 'On-Ear Headset', 'Multicolored wired noise canceling headset|Comfortable and affordable with an inline microphone|Convenient volume and mute controls', '20.49', 2, 'plantronicsM214C.png');
											   
insert into products						   
values('Jabra BT2046', 'Wireless Earbud Headset', 'Easily paired with mobile and practical to use|New and improved look|Comfortable ear hook design makes it easy to wear all day long', '24.99', 2, 'jabraBT2046.png');
											   
insert into products						   
values('Plantronics Ear Cushions', '6 Pack Black Ear Cushions', 'Useable for all plantronics earbud products|Simple to replace and install|Very affordable for mult-person use in the office', '3.89', 2, 'plantronicsEarCushion.png');
											   
insert into products						   
values('Bose Audio Cable', 'Replacement Black Audio Cable', '4 Foot audio cable designed for Bose products|Durable design means this cable with stand the test of time|Sleek black look for all devices', '6.95', 2, 'boseAudioCable.png');
											   
--av										   
insert into products						   
values('Cicso Pager', 'Invisable Clock Pager', 'Combines the functions of a clock and a pager in one|Especially usful to the hearing impaired|Also helpful for people with ADD or ADHD that need pagers', '47.74', 3, 'ciscoPager.png');
											   
insert into products						   
values('Valcom V-2003A', 'Category Paging Product', 'Accepts Pulse Dial and Tone Dial Background Music|Night Ring Time Clock Tone Door Bell Page Override|Ground-Start Trunk Port Electronic', '75.81', 3, 'valcomV2003A.png');
											   
insert into products						   
values('Logitech MeetUp Kit', 'Premier Conferencecam Video Kit', 'Captures 120 fov 4k optics|Exceptional audio performance|Delivers an unsurpassed small room experience', '1020.99', 3, 'logitectMeetup.png');
											   
insert into products						   
values('143 Beeper', 'Beeper/Pager Pin', 'Rubber clutch for maximum hold|Black nickel metal base |1.0" soft enamel pin', '10.00', 3, '143Beeper.png');
											   
--security									   
insert into products						   
values('Nest Cam', '3 MegaPixel 1080p Security Camera', 'Streams securely to your phone|Motion sensing with 130 degree field of view|Nightvision LED sensors let you see the whole room', '129.99', 4, 'nestCam.png');
											   
insert into products						   
values('Lorex Security System', 'System with 1080p Dome Cameras', 'True high definition 1080p recording on all cameras|H.264 video compression|Accurate time stamps with NTP & daylight savings time', '799.99', 4, 'lorexSecurity.png');
											   
insert into products						   
values('LM-8 Camera', 'Hidden Camera & Bug Detector', 'Is perfect for frequent travelers|Can also detect wireless microphones|Very wide 2MHz-6GHz frequency range', '149.99', 4, 'LM-8.png');
											   
insert into products						   
values('D-Link Camera', 'HD Wi-Fi Camera', '100 Degree field of view|Works in the day as well as in the night|Records up to 128GB on an SD card', '66.99', 4, 'D-LinkWiFi.png');
											   
--data networking							   
insert into products						   
values('Netgear Nighthawk', 'Gigabit Ethernet Switch', 'Advanced Gigabit Ethernet Switch is a versatile, ultra-performance and easily configurable network|4k UHD media streaming|Home network connectivity', '79.99', 5, 'nighthawk.png');
											   
insert into products						   
values('Cisco ONE', 'Gigabit Ethernet Router', 'Cconverged branch platform with industry-leading network|Meets Gigabit forwarding performance needs|Cool new design', '7560.00', 5, 'ciscoOne.png');
											   
insert into products						   
values('Monoprice Switch', '9-Port PoE Switch', 'Provides a great selection for expanding your home or office network|Automatically detects and supply power for Ieee 802.3at/af compliant Powered Devices|Simple to set up', '53.99', 5, 'monoPrice.png');
											   
insert into products						   
values('Woodstock Rocker', 'Safety Electirc Switch and Cord ', 'Mounts directly to router table|Plastic switch cover is a removable key|7 foot grounded electrical cord', '16.99', 5, 'woodstockRocker.png');
											   
--accessories								   
insert into products						   
values('AA Emergency Phone', 'Waterproof Emergency Landline Phone', 'Weatherproof enclosure, latch (padlock capable door snap latch)|Programmed 911 Only trimeline phone|Must be wired to local phone provider', '284.99', 6, 'aaEmergencyPhone.png');
											   
insert into products						   
values('Muscle Rack', '48x24x72 inch Steel Shelving', 'Easily adjustable for any area|Up to 5 shevles of storage|Crafted out of powder coated steel', '59.87', 6, 'muscleRack.png');
											   
insert into products						   
values('CLC 1528', 'Electrical & Maintenance Tool Bag', '23 Large pockets for all your tools|Shaped to prevent tipping|Plastic trays to help you organize', '44.95', 6, 'CLC1528.png');
											   
insert into products						   
values('Replacement Case', '13-Piece Tool Kit', 'Stainless steel handmade tools|Gaurenteed for 20 years|Ultra light weight', '199.99', 6, 'toolKit.png');



--------------inserting dumby data